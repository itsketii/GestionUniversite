using System.Data;
using GestionUniversite.DataAccess;
using GestionUniversite.UInterface.Composants;

namespace GestionUniversite.UInterface;

public partial class UcPlanification : UserControl
{
    private readonly SeanceDAO _dao = new SeanceDAO();
    private DateTime _lundi = LundiDe(DateTime.Today);
    private bool _chargement;
    private bool _vueCalendrier = true;

    public UcPlanification()
    {
        InitializeComponent();
    }

    private static DateTime LundiDe(DateTime d) => d.Date.AddDays(-(((int)d.DayOfWeek + 6) % 7));

    private void UcPlanification_Load(object sender, EventArgs e)
    {
        if (Outils.EstDesigner) return;
        try
        {
            var classes = ReferentielDAO.ClassesActives();
            var toutes = classes.NewRow();
            toutes["idClasse"] = 0;
            toutes["libelle"] = "Toutes les classes";
            classes.Rows.InsertAt(toutes, 0);

            _chargement = true;
            Outils.Lier(cboClasse, classes, "libelle", "idClasse");
            _chargement = false;
            AppliquerVue();
            Charger();
        }
        catch (Exception ex)
        {
            Outils.Erreur(ex.Message);
        }
    }

    private string ClasseFiltre() =>
        cboClasse.SelectedIndex > 0 ? ((DataRowView)cboClasse.SelectedItem)["libelle"].ToString() : null;

    private void Charger()
    {
        if (_chargement) return;
        try
        {
            lblSemaine.Text = $"Semaine du {_lundi:dd/MM/yyyy} au {_lundi.AddDays(6):dd/MM/yyyy}";
            string classe = ClasseFiltre();
            var brut = _dao.ListerSemaineBrut(_lundi, _lundi.AddDays(6), classe);
            grilleHebdo.Lundi = _lundi;
            grilleHebdo.Seances = brut.Rows.Cast<DataRow>().Select(r => new SeanceAff
            {
                Id = Convert.ToInt32(r["idSeance"]),
                Date = (DateTime)r["dateSeance"],
                Debut = (TimeSpan)r["heureDebut"],
                Fin = (TimeSpan)r["heureFin"],
                Matiere = (string)r["matiere"],
                Classe = (string)r["classe"],
                Salle = (string)r["salle"],
                Enseignant = (string)r["enseignant"],
                Type = (string)r["typeSeance"],
                Statut = (string)r["statut"]
            }).ToList();
            dgvSeances.DataSource = _dao.ListerSemaine(_lundi, _lundi.AddDays(6), classe);
            lblNombre.Text = $"{brut.Rows.Count} séance(s)";
        }
        catch (Exception ex)
        {
            Outils.Erreur(ex.Message);
        }
    }

    private void AppliquerVue()
    {
        grilleHebdo.Visible = _vueCalendrier;
        dgvSeances.Visible = !_vueCalendrier;
        btnVueCalendrier.BackColor = _vueCalendrier ? Theme.Primaire : Theme.Secondaire;
        btnVueCalendrier.ForeColor = _vueCalendrier ? Color.White : Theme.Texte;
        btnVueListe.BackColor = _vueCalendrier ? Theme.Secondaire : Theme.Primaire;
        btnVueListe.ForeColor = _vueCalendrier ? Theme.Texte : Color.White;
    }

    private void btnVueCalendrier_Click(object sender, EventArgs e) { _vueCalendrier = true; AppliquerVue(); }
    private void btnVueListe_Click(object sender, EventArgs e) { _vueCalendrier = false; AppliquerVue(); }
    private void btnPrecedente_Click(object sender, EventArgs e) { _lundi = _lundi.AddDays(-7); Charger(); }
    private void btnSuivante_Click(object sender, EventArgs e) { _lundi = _lundi.AddDays(7); Charger(); }
    private void btnCetteSemaine_Click(object sender, EventArgs e) { _lundi = LundiDe(DateTime.Today); Charger(); }
    private void cboClasse_SelectedIndexChanged(object sender, EventArgs e) => Charger();

    private void btnPlanifier_Click(object sender, EventArgs e)
    {
        using var f = new FrmSeanceDetail(_lundi);
        if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
    }

    private int? IdSeanceSelectionnee()
    {
        if (_vueCalendrier) return grilleHebdo.IdSelectionne == 0 ? (int?)null : grilleHebdo.IdSelectionne;
        if (dgvSeances.CurrentRow?.DataBoundItem is DataRowView ligne) return (int)ligne["idSeance"];
        return null;
    }

    private void btnAnnulerSeance_Click(object sender, EventArgs e)
    {
        int? id = IdSeanceSelectionnee();
        if (id == null)
        {
            Outils.Info("Sélectionnez d'abord une séance.");
            return;
        }
        if (!Outils.Confirmer("Annuler cette séance ?")) return;
        try
        {
            _dao.Annuler(id.Value);
            Charger();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private System.Drawing.Printing.PrintDocument NouveauDocument()
    {
        string sous = lblSemaine.Text + (ClasseFiltre() == null ? "" : " · " + ClasseFiltre());
        if (_vueCalendrier) return Impression.DocumentControle(grilleHebdo, "Emploi du temps", sous);
        return Rapport.DepuisGrille(dgvSeances, "Emploi du temps", sous).CreerDocument();
    }

    private void btnImprimer_Click(object sender, EventArgs e) => Impression.Apercu(FindForm(), NouveauDocument());

    private void btnPdf_Click(object sender, EventArgs e) => Impression.Pdf(FindForm(), NouveauDocument(), "emploi_du_temps");

    private void btnExporter_Click(object sender, EventArgs e) => Exports.CsvDepuisGrille(dgvSeances, FindForm(), "emploi_du_temps");
}
