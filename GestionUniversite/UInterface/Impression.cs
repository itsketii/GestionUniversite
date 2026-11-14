using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Globalization;
using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

// Tableau imprimable (liste, feuille d'appel, etc.) avec en-tête de l'école et pagination
public class Rapport
{
    public string Titre { get; set; } = "";
    public string SousTitre { get; set; } = "";
    public bool Paysage { get; set; } = true;
    public List<string> Entetes { get; } = new List<string>();
    public List<float> Poids { get; } = new List<float>();
    public List<string[]> Lignes { get; } = new List<string[]>();

    private int _ligne;
    private int _page;

    public static Rapport DepuisGrille(DataGridView grille, string titre, string sousTitre, bool paysage = true)
    {
        var r = new Rapport { Titre = titre, SousTitre = sousTitre, Paysage = paysage };
        var colonnes = grille.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).OrderBy(c => c.DisplayIndex).ToList();
        foreach (var c in colonnes)
        {
            r.Entetes.Add(c.HeaderText);
            r.Poids.Add(Math.Max(40, c.Width));
        }
        foreach (DataGridViewRow ligne in grille.Rows)
            r.Lignes.Add(colonnes.Select(c => Convert.ToString(ligne.Cells[c.Index].FormattedValue) ?? "").ToArray());
        return r;
    }

    public PrintDocument CreerDocument()
    {
        var doc = new PrintDocument { DocumentName = Titre };
        doc.DefaultPageSettings.Landscape = Paysage;
        doc.DefaultPageSettings.Margins = new Margins(50, 50, 45, 60);
        doc.BeginPrint += (s, e) => { _ligne = 0; _page = 0; };
        doc.PrintPage += Dessiner;
        return doc;
    }

    private void Dessiner(object sender, PrintPageEventArgs e)
    {
        var g = e.Graphics;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        var m = e.MarginBounds;
        _page++;
        float y = Impression.Entete(g, m, Titre, SousTitre);

        float total = Math.Max(1f, Poids.Sum());
        var xs = new float[Poids.Count + 1];
        xs[0] = m.Left;
        for (int i = 0; i < Poids.Count; i++) xs[i + 1] = xs[i] + m.Width * Poids[i] / total;

        using var policeEntete = new Font("Segoe UI Semibold", 9.5F);
        using var police = new Font("Segoe UI", 9.5F);
        using var fondEntete = new SolidBrush(Color.FromArgb(155, 27, 48));
        using var fondAlterne = new SolidBrush(Color.FromArgb(248, 244, 244));
        using var blanc = new SolidBrush(Color.White);
        using var noir = new SolidBrush(Color.FromArgb(27, 20, 22));
        using var trait = new Pen(Color.FromArgb(230, 222, 224));
        var format = Dessin.Format(StringAlignment.Near, StringAlignment.Center);

        float h = 26f;
        g.FillRectangle(fondEntete, m.Left, y, m.Width, h);
        for (int i = 0; i < Entetes.Count; i++)
            g.DrawString(Entetes[i], policeEntete, blanc, new RectangleF(xs[i] + 6, y, xs[i + 1] - xs[i] - 8, h), format);
        y += h;

        int vues = 0;
        while (_ligne < Lignes.Count && y + h <= m.Bottom)
        {
            if (vues % 2 == 1) g.FillRectangle(fondAlterne, m.Left, y, m.Width, h);
            for (int i = 0; i < Entetes.Count; i++)
                g.DrawString(Lignes[_ligne][i], police, noir, new RectangleF(xs[i] + 6, y, xs[i + 1] - xs[i] - 8, h), format);
            g.DrawLine(trait, m.Left, y + h, m.Right, y + h);
            y += h;
            _ligne++;
            vues++;
        }
        if (Lignes.Count == 0) g.DrawString("Aucune donnée à afficher.", police, noir, m.Left, y + 10);
        e.HasMorePages = _ligne < Lignes.Count;
        Impression.Pied(g, m, _page);
    }
}

public static class Impression
{
    private static readonly CultureInfo Fr = new CultureInfo("fr-FR");

    public static float Entete(Graphics g, Rectangle m, string titre, string sousTitre)
    {
        float y = m.Top;
        g.DrawImage(Properties.Resources.Logo_IIT_4x4, m.Left, y, 44, 48);
        using var gras = new Font("Segoe UI Semibold", 12F);
        using var grand = new Font("Segoe UI Semibold", 18F);
        using var petit = new Font("Segoe UI", 9.5F);
        using var bordeaux = new SolidBrush(Color.FromArgb(155, 27, 48));
        using var noir = new SolidBrush(Color.FromArgb(27, 20, 22));
        using var gris = new SolidBrush(Color.FromArgb(107, 96, 99));
        using var trait = new Pen(Color.FromArgb(155, 27, 48), 2f);

        g.DrawString(Parametres.Etablissement, gras, noir, m.Left + 56, y + 2);
        g.DrawString("Gestion universitaire", petit, gris, m.Left + 56, y + 26);
        var droite = Dessin.Format(StringAlignment.Far, StringAlignment.Near);
        g.DrawString("Édité le " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), petit, gris, new RectangleF(m.Left, y + 4, m.Width, 20), droite);
        if (Session.Utilisateur != null)
            g.DrawString("Par " + Session.Utilisateur.NomComplet, petit, gris, new RectangleF(m.Left, y + 26, m.Width, 20), droite);
        y += 58;
        g.DrawLine(trait, m.Left, y, m.Right, y);
        y += 12;
        g.DrawString(titre, grand, bordeaux, m.Left, y);
        y += 34;
        if (!string.IsNullOrEmpty(sousTitre))
        {
            g.DrawString(sousTitre, petit, gris, m.Left, y);
            y += 24;
        }
        return y + 6;
    }

    public static void Pied(Graphics g, Rectangle m, int page)
    {
        using var petit = new Font("Segoe UI", 8.5F);
        using var gris = new SolidBrush(Color.FromArgb(107, 96, 99));
        using var trait = new Pen(Color.FromArgb(230, 222, 224));
        float y = m.Bottom + 14;
        g.DrawLine(trait, m.Left, y, m.Right, y);
        g.DrawString(Parametres.Etablissement + " · Gestion universitaire", petit, gris, m.Left, y + 4);
        g.DrawString("Page " + page, petit, gris, new RectangleF(m.Left, y + 4, m.Width, 18), Dessin.Format(StringAlignment.Far, StringAlignment.Near));
    }

    // Document d'un contrôle (calendrier, page de statistiques) toujours imprimé en clair
    public static PrintDocument DocumentControle(Control controle, string titre, string sousTitre)
    {
        var image = Theme.Capturer(controle);
        var doc = new PrintDocument { DocumentName = titre };
        doc.DefaultPageSettings.Landscape = true;
        doc.DefaultPageSettings.Margins = new Margins(50, 50, 45, 60);
        doc.PrintPage += (s, e) =>
        {
            var g = e.Graphics;
            var m = e.MarginBounds;
            float y = Entete(g, m, titre, sousTitre);
            var zone = new RectangleF(m.Left, y, m.Width, m.Bottom - y);
            float ratio = Math.Min(zone.Width / image.Width, zone.Height / image.Height);
            float w = image.Width * ratio, h = image.Height * ratio;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(image, zone.Left + (zone.Width - w) / 2f, zone.Top, w, h);
            Pied(g, m, 1);
            e.HasMorePages = false;
        };
        doc.EndPrint += (s, e) => image.Dispose();
        return doc;
    }

    // Reçu d'inscription (une page portrait)
    public static PrintDocument DocumentRecu(DataRow r)
    {
        var doc = new PrintDocument { DocumentName = "Reçu d'inscription" };
        doc.DefaultPageSettings.Margins = new Margins(60, 60, 50, 60);
        doc.PrintPage += (s, e) =>
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            var m = e.MarginBounds;
            string annee = Convert.ToString(r["annee"]);
            int id = Convert.ToInt32(r["idInscription"]);
            float y = Entete(g, m, "REÇU D’INSCRIPTION", "N° REC-" + annee.Substring(0, Math.Min(4, annee.Length)) + "-" + id.ToString("00000"));
            y += 10;

            using var police = new Font("Segoe UI", 11F);
            using var gras = new Font("Segoe UI Semibold", 11F);
            using var gris = new SolidBrush(Color.FromArgb(107, 96, 99));
            using var noir = new SolidBrush(Color.FromArgb(27, 20, 22));
            using var trait = new Pen(Color.FromArgb(230, 222, 224));
            var gauche = Dessin.Format(StringAlignment.Near, StringAlignment.Center);

            var lignes = new[]
            {
                new[] { "Étudiant", Convert.ToString(r["etudiant"]) },
                new[] { "Matricule", Convert.ToString(r["matricule"]) },
                new[] { "Classe", Convert.ToString(r["classe"]) },
                new[] { "Année académique", annee },
                new[] { "Date d’inscription", Convert.ToDateTime(r["dateInscription"]).ToString("dd/MM/yyyy") },
                new[] { "Statut", Convert.ToString(r["statut"]) }
            };
            foreach (var ligne in lignes)
            {
                g.DrawString(ligne[0], police, gris, new RectangleF(m.Left, y, m.Width * 0.4f, 38), gauche);
                g.DrawString(ligne[1], gras, noir, new RectangleF(m.Left + m.Width * 0.4f, y, m.Width * 0.6f, 38), gauche);
                y += 38;
                g.DrawLine(trait, m.Left, y, m.Right, y);
            }

            y += 30;
            var boite = new RectangleF(m.Left, y, m.Width, 96);
            using (var chemin = Dessin.RectArrondi(boite, 14))
            using (var fond = new SolidBrush(Color.FromArgb(155, 27, 48)))
                g.FillPath(fond, chemin);
            using (var blanc = new SolidBrush(Color.White))
            using (var petit = new Font("Segoe UI", 10.5F))
            using (var grand = new Font("Segoe UI Semibold", 24F))
            {
                g.DrawString("Frais d’inscription", petit, blanc, boite.X + 24, boite.Y + 14);
                string montant = Convert.ToDecimal(r["fraisInscription"]).ToString("N0", Fr) + " FCFA";
                g.DrawString(montant, grand, blanc, boite.X + 24, boite.Y + 38);
            }

            y += 150;
            g.DrawString("La scolarité", gras, noir, m.Left, y);
            g.DrawString("L’étudiant(e)", gras, noir, new RectangleF(m.Left, y, m.Width, 24), Dessin.Format(StringAlignment.Far, StringAlignment.Near));
            g.DrawLine(trait, m.Left, y + 90, m.Left + 200, y + 90);
            g.DrawLine(trait, m.Right - 200, y + 90, m.Right, y + 90);

            Pied(g, m, 1);
            e.HasMorePages = false;
        };
        return doc;
    }

    public static void Apercu(IWin32Window parent, PrintDocument document)
    {
        try
        {
            using var dlg = new PrintPreviewDialog
            {
                Document = document,
                UseAntiAlias = true,
                StartPosition = FormStartPosition.CenterParent,
                Width = 1200,
                Height = 860,
                Text = "Aperçu avant impression"
            };
            dlg.ShowDialog(parent);
        }
        catch (Exception ex)
        {
            Outils.Erreur("Impression impossible : " + ex.Message);
        }
    }

    // Enregistre le document en PDF grâce à l'imprimante Windows « Microsoft Print to PDF »
    public static void Pdf(IWin32Window parent, PrintDocument document, string nomFichier)
    {
        using var dlg = new SaveFileDialog
        {
            Filter = "Document PDF (*.pdf)|*.pdf",
            FileName = nomFichier + "_" + DateTime.Now.ToString("yyyyMMdd") + ".pdf"
        };
        if (dlg.ShowDialog(parent) != DialogResult.OK) return;

        try
        {
            document.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            if (!document.PrinterSettings.IsValid)
                throw new InvalidOperationException("L'imprimante « Microsoft Print to PDF » est introuvable sur ce poste.");
            document.PrinterSettings.PrintToFile = true;
            document.PrinterSettings.PrintFileName = dlg.FileName;
            document.Print();
            Exports.Proposer(dlg.FileName, "PDF enregistré.");
        }
        catch (Exception ex)
        {
            Outils.Erreur("Export PDF impossible : " + ex.Message);
        }
    }
}
