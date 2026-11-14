using System.Data;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class UcEtudiants : UserControl
{
    private readonly EtudiantDAO _dao = new EtudiantDAO();
    private DataView _vue;

    public UcEtudiants()
    {
        InitializeComponent();
    }

    private void UcEtudiants_Load(object sender, EventArgs e)
    {
        if (Outils.EstDesigner) return;
        Charger();
    }

    private void Charger()
    {
        try
        {
            _vue = _dao.GetListe().DefaultView;
            dgvEtudiants.DataSource = _vue;
            Filtrer();
        }
        catch (Exception ex)
        {
            Outils.Erreur(ex.Message);
        }
    }

    private void Filtrer()
    {
        if (_vue == null) return;
        string t = Outils.Nettoyer(txtRecherche.Text);
        _vue.RowFilter = t == "" ? "" : $"nom LIKE '%{t}%' OR prenoms LIKE '%{t}%' OR matricule LIKE '%{t}%' OR email LIKE '%{t}%'";
        lblNombre.Text = $"{_vue.Count} étudiant(s)";
    }

    private int? IdSelectionne()
    {
        if (dgvEtudiants.CurrentRow?.DataBoundItem is DataRowView ligne) return (int)ligne["idEtudiant"];
        return null;
    }

    private void txtRecherche_TextChanged(object sender, EventArgs e) => Filtrer();

    private void btnNouveau_Click(object sender, EventArgs e)
    {
        using var f = new FrmEtudiantDetail();
        if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
    }

    private void btnModifier_Click(object sender, EventArgs e)
    {
        int? id = IdSelectionne();
        if (id == null) return;
        try
        {
            using var f = new FrmEtudiantDetail(_dao.GetById(id.Value));
            if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
        }
        catch (Exception ex)
        {
            Outils.Erreur(ex.Message);
        }
    }

    private void dgvEtudiants_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) btnModifier_Click(sender, e);
    }

    private void btnSupprimer_Click(object sender, EventArgs e)
    {
        int? id = IdSelectionne();
        if (id == null) return;
        if (!Outils.Confirmer("Supprimer l’étudiant sélectionné ?")) return;
        try
        {
            _dao.Delete(id.Value);
            Charger();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Suppression impossible : cet élément est utilisé ailleurs dans l’application.\n\n" + ex.Message,
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private Rapport NouveauRapport() =>
        Rapport.DepuisGrille(dgvEtudiants, "Étudiants", $"{_vue?.Count ?? 0} étudiant(s)");

    private void btnExporter_Click(object sender, EventArgs e) => Exports.CsvDepuisGrille(dgvEtudiants, FindForm(), "etudiants");

    private void btnImprimer_Click(object sender, EventArgs e) => Impression.Apercu(FindForm(), NouveauRapport().CreerDocument());

    private void btnPdf_Click(object sender, EventArgs e) => Impression.Pdf(FindForm(), NouveauRapport().CreerDocument(), "etudiants");
}
