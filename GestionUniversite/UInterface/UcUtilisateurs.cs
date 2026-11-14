using System.Data;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class UcUtilisateurs : UserControl
{
    private readonly UtilisateurDAO _dao = new UtilisateurDAO();
    private DataView _vue;

    public UcUtilisateurs()
    {
        InitializeComponent();
    }

    private void UcUtilisateurs_Load(object sender, EventArgs e)
    {
        if (Outils.EstDesigner) return;
        Charger();
    }

    private void Charger()
    {
        try
        {
            _vue = _dao.Lister().DefaultView;
            dgvUtilisateurs.DataSource = _vue;
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
        _vue.RowFilter = t == "" ? "" : $"nomComplet LIKE '%{t}%' OR email LIKE '%{t}%' OR role LIKE '%{t}%'";
        lblNombre.Text = $"{_vue.Count} utilisateur(s)";
    }

    private int? IdSelectionne()
    {
        if (dgvUtilisateurs.CurrentRow?.DataBoundItem is DataRowView ligne) return (int)ligne["idUtilisateur"];
        return null;
    }

    private void txtRecherche_TextChanged(object sender, EventArgs e) => Filtrer();

    private void btnNouveau_Click(object sender, EventArgs e)
    {
        using var f = new FrmUtilisateurDetail();
        if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
    }

    private void btnModifier_Click(object sender, EventArgs e)
    {
        int? id = IdSelectionne();
        if (id == null) return;
        try
        {
            using var f = new FrmUtilisateurDetail(_dao.Obtenir(id.Value));
            if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
        }
        catch (Exception ex)
        {
            Outils.Erreur(ex.Message);
        }
    }

    private void dgvUtilisateurs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0) btnModifier_Click(sender, e);
    }

    private void btnSupprimer_Click(object sender, EventArgs e)
    {
        int? id = IdSelectionne();
        if (id == null) return;
        if (id == Session.Utilisateur?.IdUtilisateur)
        {
            Outils.Info("Vous ne pouvez pas supprimer votre propre compte.");
            return;
        }
        if (!Outils.Confirmer("Supprimer l’utilisateur sélectionné ?")) return;
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
        Rapport.DepuisGrille(dgvUtilisateurs, "Utilisateurs", $"{_vue?.Count ?? 0} utilisateur(s)");

    private void btnExporter_Click(object sender, EventArgs e) => Exports.CsvDepuisGrille(dgvUtilisateurs, FindForm(), "utilisateurs");

    private void btnImprimer_Click(object sender, EventArgs e) => Impression.Apercu(FindForm(), NouveauRapport().CreerDocument());

    private void btnPdf_Click(object sender, EventArgs e) => Impression.Pdf(FindForm(), NouveauRapport().CreerDocument(), "utilisateurs");
}
