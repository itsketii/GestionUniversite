
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace GestionUniversite.UInterface.Composants;

// Barres horizontales : le libellé est écrit au-dessus de la barre quand il y a la place
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

    private static void DessinerBarre(Graphics g, float x, float y, float largeur, float hauteur, double part, Color couleur)
    {
        using (var piste = Dessin.RectArrondi(new RectangleF(x, y, Math.Max(2f, largeur), hauteur), hauteur / 2f))
        using (var brossePiste = new SolidBrush(Theme.Bordure))
            g.FillPath(brossePiste, piste);

        float w = (float)(largeur * part);
        if (w > 1f)
        {
            using var barre = Dessin.RectArrondi(new RectangleF(x, y, Math.Max(w, hauteur), hauteur), hauteur / 2f);
            using var brosse = new SolidBrush(couleur);
            g.FillPath(brosse, barre);
        }
    }

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
                new KeyValuePair<string, double>("Informatique et Génie Logiciel", 64),
                new KeyValuePair<string, double>("Réseaux et Télécommunications", 41),
                new KeyValuePair<string, double>("Science des données", 27)
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

        float ech = DeviceDpi / 96f;
        double max = Math.Max(1, data.Max(d => d.Value));
        float ligne = Math.Min(64f * ech, (float)Height / data.Count);
        bool empile = ligne >= 44f * ech;
        float hauteurTexte = police.GetHeight(g);
        float largeurValeur = 46f * ech;
        float hauteurBarre = Math.Min(12f * ech, ligne * 0.3f);
        var palette = Theme.Palette;
        var formatTexte = Dessin.Format(StringAlignment.Near, StringAlignment.Center);

        if (empile)
        {
            for (int i = 0; i < data.Count; i++)
            {
                float y = i * ligne;
                float bloc = hauteurTexte + 5f * ech + hauteurBarre;
                float yTexte = y + (ligne - bloc) / 2f;
                float yBarre = yTexte + hauteurTexte + 5f * ech;
                float xFin = Width - largeurValeur;

                g.DrawString(data[i].Key, police, brosseTexte, new RectangleF(0, yTexte, Width - 4, hauteurTexte + 2), formatTexte);
                DessinerBarre(g, 0, yBarre, xFin - 6f * ech, hauteurBarre, data[i].Value / max, palette[i % palette.Length]);
                g.DrawString(data[i].Value.ToString("0.##"), policeValeur, brosseTexte,
                    new RectangleF(xFin, yBarre + hauteurBarre / 2f - hauteurTexte / 2f, largeurValeur, hauteurTexte), formatTexte);
            }
            return;
        }

        // beaucoup de lignes : libellé à gauche, barre au centre, valeur à droite
        float largeurLibelle = 0;
        foreach (var d in data) largeurLibelle = Math.Max(largeurLibelle, g.MeasureString(d.Key, police).Width);
        largeurLibelle = Math.Min(largeurLibelle + 8f, Width * 0.5f);
        float x0 = largeurLibelle + 8f * ech, x1 = Width - largeurValeur;
        for (int i = 0; i < data.Count; i++)
        {
            float y = i * ligne;
            float yb = y + (ligne - hauteurBarre) / 2f;
            g.DrawString(data[i].Key, police, brosseTexte, new RectangleF(0, y, largeurLibelle, ligne), formatTexte);
            DessinerBarre(g, x0, yb, x1 - x0 - 6f * ech, hauteurBarre, data[i].Value / max, palette[i % palette.Length]);
            g.DrawString(data[i].Value.ToString("0.##"), policeValeur, brosseTexte, new RectangleF(x1, y, largeurValeur, ligne), formatTexte);
        }
    }
}
