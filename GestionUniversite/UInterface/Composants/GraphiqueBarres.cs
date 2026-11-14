using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace GestionUniversite.UInterface.Composants;

// Barres horizontales : une ligne par élément (libellé, barre, valeur)
public class GraphiqueBarres : Control, IThemable
{
    private List<KeyValuePair<string, double>> _donnees = new List<KeyValuePair<string, double>>();

    public GraphiqueBarres()
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
                new KeyValuePair<string, double>("Génie Logiciel", 64),
                new KeyValuePair<string, double>("Réseaux", 41),
                new KeyValuePair<string, double>("Data", 27)
            };

        using var police = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
        using var policeValeur = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point);
        using var brosseTexte = new SolidBrush(Theme.Texte);
        using var brosseDiscret = new SolidBrush(Theme.TexteDiscret);

        if (data.Count == 0)
        {
            g.DrawString("Aucune donnée", police, brosseDiscret, ClientRectangle, Dessin.Format(StringAlignment.Center, StringAlignment.Center));
            return;
        }

        double max = Math.Max(1, data.Max(d => d.Value));
        float s = DeviceDpi / 96f;
        float ligne = Math.Min(48f * s, (float)Height / data.Count);
        float largeurLibelle = 0;
        foreach (var d in data) largeurLibelle = Math.Max(largeurLibelle, g.MeasureString(d.Key, police).Width);
        largeurLibelle = Math.Min(largeurLibelle + 8, Width * 0.38f);
        float largeurValeur = 56f * s;
        float x0 = largeurLibelle + 10, x1 = Width - largeurValeur;
        var palette = Theme.Palette;

        for (int i = 0; i < data.Count; i++)
        {
            float y = i * ligne;
            float hauteurBarre = Math.Min(16f * s, ligne * 0.42f);
            float yb = y + (ligne - hauteurBarre) / 2f;
            g.DrawString(data[i].Key, police, brosseTexte, new RectangleF(0, y, largeurLibelle, ligne), Dessin.Format(StringAlignment.Near, StringAlignment.Center));

            using (var piste = Dessin.RectArrondi(new RectangleF(x0, yb, Math.Max(2, x1 - x0), hauteurBarre), hauteurBarre / 2f))
            using (var brossePiste = new SolidBrush(Theme.Bordure))
                g.FillPath(brossePiste, piste);

            float w = (float)((x1 - x0) * (data[i].Value / max));
            if (w > 1)
            {
                using var barre = Dessin.RectArrondi(new RectangleF(x0, yb, Math.Max(w, hauteurBarre), hauteurBarre), hauteurBarre / 2f);
                using var brosse = new SolidBrush(palette[i % palette.Length]);
                g.FillPath(brosse, barre);
            }
            g.DrawString(data[i].Value.ToString("0.##"), policeValeur, brosseTexte, new RectangleF(x1 + 6, y, largeurValeur - 6, ligne), Dessin.Format(StringAlignment.Near, StringAlignment.Center));
        }
    }
}
