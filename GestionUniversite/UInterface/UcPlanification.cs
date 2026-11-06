using System.Data;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class UcPlanification : UserControl
{
    private readonly SeanceDAO _dao = new SeanceDAO();
    private DateTime _lundi = LundiDe(DateTime.Today);
    private bool _chargement;

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
            Charger();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void Charger()
    {
        if (_chargement) return;
        try
        {
            lblSemaine.Text = $"Semaine du {_lundi:dd/MM/yyyy} au {_lundi.AddDays(6):dd/MM/yyyy}";
            string classe = cboClasse.SelectedIndex > 0 ? ((DataRowView)cboClasse.SelectedItem)["libelle"].ToString() : null;
            var table = _dao.ListerSemaine(_lundi, _lundi.AddDays(6), classe);
            dgvSeances.DataSource = table;
            lblNombre.Text = $"{table.Rows.Count} séance(s)";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnPrecedente_Click(object sender, EventArgs e) { _lundi = _lundi.AddDays(-7); Charger(); }
    private void btnSuivante_Click(object sender, EventArgs e) { _lundi = _lundi.AddDays(7); Charger(); }
    private void btnCetteSemaine_Click(object sender, EventArgs e) { _lundi = LundiDe(DateTime.Today); Charger(); }
    private void cboClasse_SelectedIndexChanged(object sender, EventArgs e) => Charger();

    private void btnPlanifier_Click(object sender, EventArgs e)
    {
        using var f = new FrmSeanceDetail(_lundi);
        if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
    }

    private void btnAnnulerSeance_Click(object sender, EventArgs e)
    {
        if (dgvSeances.CurrentRow?.DataBoundItem is not DataRowView ligne) return;
        if (MessageBox.Show("Annuler cette séance ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        try
        {
            _dao.Annuler((int)ligne["idSeance"]);
            Charger();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
