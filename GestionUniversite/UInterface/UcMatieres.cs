using System.Data;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class UcMatieres : UserControl
{
    private readonly MatiereDAO _dao = new MatiereDAO();
    private DataView _vue;

    public UcMatieres()
    {
        InitializeComponent();
    }

    private void UcMatieres_Load(object sender, EventArgs e)
    {
        if (Outils.EstDesigner) return;
        Charger();
    }

    private void Charger()
    {
        try
        {
            _vue = _dao.Lister().DefaultView;
            dgvMatieres.DataSource = _vue;
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
        _vue.RowFilter = t == "" ? "" : $"codeMatiere LIKE '%{t}%' OR intitule LIKE '%{t}%'";
        lblNombre.Text = $"{_vue.Count} matière(s)";
    }

    private int? IdSelectionne()
    {
        if (dgvMatieres.CurrentRow?.DataBoundItem is DataRowView ligne) return (int)ligne["idMatiere"];
        return null;
    }

    private void txtRecherche_TextChanged(object sender, EventArgs e) => Filtrer();

    private void btnNouveau_Click(object sender, EventArgs e)
    {
        using var f = new FrmMatiereDetail();
        if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
    }

    private void btnModifier_Click(object sender, EventArgs e)
    {
        int? id = IdSelectionne();
        if (id == null) return;
        try
        {
            using var f = new FrmMatiereDetail(_dao.Obtenir(id.Value));
            if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
        }
        catch (Exception ex)
        {
            Outils.Erreur(ex.Message);
        }
    }

    private void dgvMatieres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) btnModifier_Click(sender, e);
    }

    private void btnSupprimer_Click(object sender, EventArgs e)
    {
        int? id = IdSelectionne();
        if (id == null) return;
        if (!Outils.Confirmer("Supprimer la matière sélectionné ?")) return;
        try
        {
            _dao.Supprimer(id.Value);
            Charger();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Suppression impossible : cet élément est utilisé ailleurs dans l’application.\n\n" + ex.Message,
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private Rapport NouveauRapport() =>
        Rapport.DepuisGrille(dgvMatieres, "Matières", $"{_vue?.Count ?? 0} matière(s)");

    private void btnExporter_Click(object sender, EventArgs e) => Exports.CsvDepuisGrille(dgvMatieres, FindForm(), "matieres");

    private void btnImprimer_Click(object sender, EventArgs e) => Impression.Apercu(FindForm(), NouveauRapport().CreerDocument());

    private void btnPdf_Click(object sender, EventArgs e) => Impression.Pdf(FindForm(), NouveauRapport().CreerDocument(), "matieres");
}
