using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;

namespace GestionUniversite.UInterface.Composants;

public class SeanceAff
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public TimeSpan Debut { get; set; }
    public TimeSpan Fin { get; set; }
    public string Matiere { get; set; }
    public string Classe { get; set; }
    public string Salle { get; set; }
    public string Enseignant { get; set; }
    public string Type { get; set; }
    public string Statut { get; set; }
}

// Emploi du temps hebdomadaire dessiné (lundi à samedi)
public class GrilleHebdo : Control, IThemable
{
    private readonly List<(RectangleF zone, SeanceAff seance)> _zones = new List<(RectangleF, SeanceAff)>();
    private List<SeanceAff> _seances = new List<SeanceAff>();
    private DateTime _lundi = DateTime.Today;
    private int _idSelectionne;

    public event EventHandler SelectionChanged;

    public GrilleHebdo()
    {
        DoubleBuffered = true;
        ResizeRedraw = true;
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public List<SeanceAff> Seances
    {
        get => _seances;
        set { _seances = value ?? new List<SeanceAff>(); Invalidate(); }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public DateTime Lundi
    {
        get => _lundi;
        set { _lundi = value.Date; Invalidate(); }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public int IdSelectionne => _idSelectionne;

    public void AppliquerTheme() => Invalidate();

    private bool EnConception => DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime;

    public static Color CouleurType(string type)
    {
        switch (type)
        {
            case "TD": return Color.FromArgb(74, 85, 104);
            case "TP": return Color.FromArgb(180, 83, 9);
            default: return Color.FromArgb(155, 27, 48);
        }
    }

    protected override void OnMouseClick(MouseEventArgs e)
    {
        base.OnMouseClick(e);
        int id = 0;
        foreach (var z in _zones)
            if (z.zone.Contains(e.Location)) id = z.seance.Id;
        _idSelectionne = id;
        Invalidate();
        SelectionChanged?.Invoke(this, EventArgs.Empty);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.Clear(BackColor);
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
        _zones.Clear();

        var seances = _seances;
        if (seances.Count == 0 && EnConception)
            seances = new List<SeanceAff>
            {
                new SeanceAff { Id = 1, Date = _lundi, Debut = new TimeSpan(8, 0, 0), Fin = new TimeSpan(10, 0, 0), Matiere = "Algorithmique", Classe = "L2 IGL", Salle = "B12", Type = "CM", Statut = "Planifiée" },
                new SeanceAff { Id = 2, Date = _lundi.AddDays(1), Debut = new TimeSpan(10, 15, 0), Fin = new TimeSpan(12, 15, 0), Matiere = "Base de données", Classe = "L2 IGL", Salle = "LABO1", Type = "TP", Statut = "Planifiée" },
                new SeanceAff { Id = 3, Date = _lundi.AddDays(3), Debut = new TimeSpan(14, 0, 0), Fin = new TimeSpan(16, 0, 0), Matiere = "Robotique", Classe = "L2 IGL", Salle = "A1", Type = "TD", Statut = "Planifiée" }
            };

        var fr = new CultureInfo("fr-FR");
        int jours = 6;
        float echelle = DeviceDpi / 96f;
        float entete = 58f * echelle, colHeures = 64f * echelle;
        int hDebut = 8, hFin = 18;
        foreach (var seance in seances)
        {
            hDebut = Math.Min(hDebut, (int)Math.Floor(seance.Debut.TotalHours));
            hFin = Math.Max(hFin, (int)Math.Ceiling(seance.Fin.TotalHours));
        }
        float hauteurHeure = Math.Max(36f * echelle, (Height - entete) / (hFin - hDebut));
        float largeurJour = (Width - colHeures) / jours;

        using var police = new Font("Segoe UI", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        using var policeGrasse = new Font("Segoe UI Semibold", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
        using var policeBarree = new Font("Segoe UI", 9F, FontStyle.Strikeout, GraphicsUnit.Point);
        using var brosseDiscret = new SolidBrush(Theme.TexteDiscret);
        using var brosseTexte = new SolidBrush(Theme.Texte);
        using var stylo = new Pen(Theme.Bordure, 1f);

        for (int h = hDebut; h <= hFin; h++)
        {
            float y = entete + (h - hDebut) * hauteurHeure;
            g.DrawLine(stylo, colHeures, y, Width, y);
            g.DrawString(h.ToString("00") + ":00", police, brosseDiscret, new RectangleF(0, y - 10 * echelle, colHeures - 8 * echelle, 20 * echelle), Dessin.Format(StringAlignment.Far, StringAlignment.Center));
        }

        for (int j = 0; j < jours; j++)
        {
            float x = colHeures + j * largeurJour;
            g.DrawLine(stylo, x, entete - 8, x, Height);
            var date = _lundi.AddDays(j);
            bool aujourdhui = date.Date == DateTime.Today;
            string nom = fr.TextInfo.ToTitleCase(fr.DateTimeFormat.GetDayName(date.DayOfWeek));
            var zoneTitre = new RectangleF(x + 4, 4, largeurJour - 8, entete - 12 * echelle);
            if (aujourdhui)
            {
                using var chemin = Dessin.RectArrondi(zoneTitre, 10);
                using var fond = new SolidBrush(Theme.Primaire);
                g.FillPath(fond, chemin);
            }
            using (var brosse = new SolidBrush(aujourdhui ? Color.White : Theme.Texte))
            using (var brosseSous = new SolidBrush(aujourdhui ? Color.White : Theme.TexteDiscret))
            {
                g.DrawString(nom, policeGrasse, brosse, new RectangleF(zoneTitre.X, zoneTitre.Y + 3 * echelle, zoneTitre.Width, 22 * echelle), Dessin.Format(StringAlignment.Center, StringAlignment.Center));
                g.DrawString(date.ToString("dd MMM", fr), police, brosseSous, new RectangleF(zoneTitre.X, zoneTitre.Y + 25 * echelle, zoneTitre.Width, 20 * echelle), Dessin.Format(StringAlignment.Center, StringAlignment.Center));
            }
        }

        float lh = policeGrasse.GetHeight(g) + 2f;
        for (int j = 0; j < jours; j++)
        {
            var duJour = seances.Where(s => (s.Date.Date - _lundi.Date).Days == j).OrderBy(s => s.Debut).ThenBy(s => s.Fin).ToList();
            var colonnes = new List<TimeSpan>();
            var affectation = new Dictionary<SeanceAff, int>();
            var groupe = new List<SeanceAff>();
            var finGroupe = TimeSpan.Zero;
            var reperes = new List<(List<SeanceAff> membres, int nb)>();
            foreach (var seance in duJour)
            {
                if (groupe.Count > 0 && seance.Debut >= finGroupe)
                {
                    reperes.Add((groupe, colonnes.Count));
                    groupe = new List<SeanceAff>();
                    colonnes = new List<TimeSpan>();
                }
                int c = colonnes.FindIndex(fin => fin <= seance.Debut);
                if (c < 0) { colonnes.Add(seance.Fin); c = colonnes.Count - 1; }
                else colonnes[c] = seance.Fin;
                affectation[seance] = c;
                groupe.Add(seance);
                finGroupe = groupe.Max(m => m.Fin);
            }
            if (groupe.Count > 0) reperes.Add((groupe, colonnes.Count));

            foreach (var (membres, nb) in reperes)
            {
                foreach (var seance in membres)
                {
                    float largeur = (largeurJour - 8) / nb;
                    float x = colHeures + j * largeurJour + 4 + affectation[seance] * largeur;
                    float y1 = entete + (float)(seance.Debut.TotalHours - hDebut) * hauteurHeure + 2;
                    float y2 = entete + (float)(seance.Fin.TotalHours - hDebut) * hauteurHeure - 2;
                    var r = new RectangleF(x, y1, largeur - 3, Math.Max(24 * echelle, y2 - y1));
                    _zones.Add((r, seance));

                    bool annulee = seance.Statut == "Annulée";
                    Color fond = annulee ? Theme.Bordure : CouleurType(seance.Type);
                    using (var chemin = Dessin.RectArrondi(r, 8))
                    using (var brosseFond = new SolidBrush(fond))
                        g.FillPath(brosseFond, chemin);
                    if (seance.Id == _idSelectionne)
                        using (var chemin = Dessin.RectArrondi(r, 8))
                        using (var contour = new Pen(Theme.Texte, 2.5f))
                            g.DrawPath(contour, chemin);

                    var etat = g.Save();
                    g.SetClip(RectangleF.Inflate(r, -6, -4));
                    using (var brosseBlanc = new SolidBrush(annulee ? Theme.TexteDiscret : Color.White))
                    {
                        g.DrawString(seance.Matiere, annulee ? policeBarree : policeGrasse, brosseBlanc, new RectangleF(r.X + 8, r.Y + 4 * echelle, r.Width - 12, lh), Dessin.Format(StringAlignment.Near, StringAlignment.Near));
                        g.DrawString(seance.Type + " · " + seance.Classe, police, brosseBlanc, new RectangleF(r.X + 8, r.Y + 4 * echelle + lh, r.Width - 12, lh), Dessin.Format(StringAlignment.Near, StringAlignment.Near));
                        g.DrawString("Salle " + seance.Salle + "  " + seance.Debut.ToString(@"hh\:mm") + "-" + seance.Fin.ToString(@"hh\:mm"), police, brosseBlanc, new RectangleF(r.X + 8, r.Y + 4 * echelle + 2 * lh, r.Width - 12, lh), Dessin.Format(StringAlignment.Near, StringAlignment.Near));
                    }
                    g.Restore(etat);
                }
            }
        }
    }
}
