using System.Data;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class UcSalles : UserControl
{
    private readonly SalleDAO _dao = new SalleDAO();
    private DataView _vue;

    public UcSalles()
    {
        InitializeComponent();
    }

    private void UcSalles_Load(object sender, EventArgs e)
    {
        if (Outils.EstDesigner) return;
        Charger();
    }

    private void Charger()
    {
        try
        {
            _vue = _dao.Lister().DefaultView;
            dgvSalles.DataSource = _vue;
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
        _vue.RowFilter = t == "" ? "" : $"codeSalle LIKE '%{t}%' OR typeSalle LIKE '%{t}%' OR batiment LIKE '%{t}%'";
        lblNombre.Text = $"{_vue.Count} salle(s)";
    }

    private int? IdSelectionne()
    {
        if (dgvSalles.CurrentRow?.DataBoundItem is DataRowView ligne) return (int)ligne["idSalle"];
        return null;
    }

    private void txtRecherche_TextChanged(object sender, EventArgs e) => Filtrer();

    private void btnNouveau_Click(object sender, EventArgs e)
    {
        using var f = new FrmSalleDetail();
        if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
    }

    private void btnModifier_Click(object sender, EventArgs e)
    {
        int? id = IdSelectionne();
        if (id == null) return;
        try
        {
            using var f = new FrmSalleDetail(_dao.Obtenir(id.Value));
            if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
        }
        catch (Exception ex)
        {
            Outils.Erreur(ex.Message);
        }
    }

    private void dgvSalles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) btnModifier_Click(sender, e);
    }

    private void btnSupprimer_Click(object sender, EventArgs e)
    {
        int? id = IdSelectionne();
        if (id == null) return;
        if (!Outils.Confirmer("Supprimer la salle sélectionné ?")) return;
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
        Rapport.DepuisGrille(dgvSalles, "Salles", $"{_vue?.Count ?? 0} salle(s)");

    private void btnExporter_Click(object sender, EventArgs e) => Exports.CsvDepuisGrille(dgvSalles, FindForm(), "salles");

    private void btnImprimer_Click(object sender, EventArgs e) => Impression.Apercu(FindForm(), NouveauRapport().CreerDocument());

    private void btnPdf_Click(object sender, EventArgs e) => Impression.Pdf(FindForm(), NouveauRapport().CreerDocument(), "salles");
}
