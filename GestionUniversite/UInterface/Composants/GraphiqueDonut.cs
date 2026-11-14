using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace GestionUniversite.UInterface.Composants;

// Anneau de répartition avec légende
public class GraphiqueDonut : Control, IThemable
{
    private List<KeyValuePair<string, double>> _donnees = new List<KeyValuePair<string, double>>();

    public GraphiqueDonut()
    {
        DoubleBuffered = true;
        ResizeRedraw = true;
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public List<KeyValuePair<string, double>> Donnees
    {
        get => _donnees;
        set { _donnees = value ?? new List<KeyValuePair<string, double>>(); Invalidate(); }
    }

    public void AppliquerTheme() => Invalidate();

    private bool EnConception => DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime;

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.Clear(BackColor);
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

        var data = _donnees;
        if (data.Count == 0 && EnConception)
            data = new List<KeyValuePair<string, double>>
            {
                new KeyValuePair<string, double>("Validées", 70),
                new KeyValuePair<string, double>("En attente", 20),
                new KeyValuePair<string, double>("Annulées", 10)
            };

        using var police = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        using var policeGrasse = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
        using var brosseTexte = new SolidBrush(Theme.Texte);
        using var brosseDiscret = new SolidBrush(Theme.TexteDiscret);

        double total = data.Sum(d => d.Value);
        if (data.Count == 0 || total <= 0)
        {
            g.DrawString("Aucune donnée", police, brosseDiscret, ClientRectangle, Dessin.Format(StringAlignment.Center, StringAlignment.Center));
            return;
        }

        float s = DeviceDpi / 96f;
        int cote = Math.Max((int)(60 * s), Math.Min(Height - 8, (int)(Width * 0.5f)));
        float epaisseur = cote * 0.17f;
        float x = 6, y = (Height - cote) / 2f;
        var zone = new RectangleF(x + epaisseur / 2f, y + epaisseur / 2f, cote - epaisseur, cote - epaisseur);
        var palette = Theme.Palette;

        float debut = -90f;
        float ecart = data.Count > 1 ? 2f : 0f;
        for (int i = 0; i < data.Count; i++)
        {
            float balayage = (float)(360.0 * data[i].Value / total);
            if (balayage <= 0) continue;
            using var stylo = new Pen(palette[i % palette.Length], epaisseur) { LineJoin = LineJoin.Round };
            g.DrawArc(stylo, zone, debut, Math.Max(0.5f, balayage - ecart));
            debut += balayage;
        }

        using (var grand = new Font("Segoe UI Semibold", Math.Max(12f, cote * 0.12f), FontStyle.Regular, GraphicsUnit.Point))
        {
            var centre = new RectangleF(x, y, cote, cote - 10);
            g.DrawString(total.ToString("0.##"), grand, brosseTexte, centre, Dessin.Format(StringAlignment.Center, StringAlignment.Center));
            g.DrawString("total", police, brosseDiscret, new RectangleF(x, y + cote * 0.54f, cote, 24 * s), Dessin.Format(StringAlignment.Center, StringAlignment.Near));
        }

        float xl = x + cote + 24 * s;
        float hl = 28f * s;
        float yl = (Height - data.Count * hl) / 2f;
        for (int i = 0; i < data.Count; i++)
        {
            float yy = yl + i * hl;
            using (var pastille = new SolidBrush(palette[i % palette.Length]))
                g.FillEllipse(pastille, xl, yy + hl / 2f - 6 * s, 12 * s, 12 * s);
            g.DrawString(data[i].Key, police, brosseTexte, new RectangleF(xl + 20 * s, yy, Math.Max(10, Width - xl - 20 * s - 120 * s), hl), Dessin.Format(StringAlignment.Near, StringAlignment.Center));
            string valeur = data[i].Value.ToString("0.##") + "  (" + (100.0 * data[i].Value / total).ToString("0") + " %)";
            g.DrawString(valeur, policeGrasse, brosseDiscret, new RectangleF(Width - 120 * s, yy, 118 * s, hl), Dessin.Format(StringAlignment.Far, StringAlignment.Center));
        }
    }
}
