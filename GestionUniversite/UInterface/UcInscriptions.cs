using System.Data;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class UcInscriptions : UserControl
{
    private readonly InscriptionDAO _dao = new InscriptionDAO();
    private DataView _vue;

    public UcInscriptions()
    {
        InitializeComponent();
    }

    private void UcInscriptions_Load(object sender, EventArgs e)
    {
        if (Outils.EstDesigner) return;
        Charger();
    }

    private void Charger()
    {
        try
        {
            _vue = _dao.GetListe().DefaultView;
            dgvInscriptions.DataSource = _vue;
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
        _vue.RowFilter = t == "" ? "" : $"etudiant LIKE '%{t}%' OR classe LIKE '%{t}%' OR matricule LIKE '%{t}%'";
        lblNombre.Text = $"{_vue.Count} inscription(s)";
    }

    private int? IdSelectionne()
    {
        if (dgvInscriptions.CurrentRow?.DataBoundItem is DataRowView ligne) return (int)ligne["idInscription"];
        return null;
    }

    private void txtRecherche_TextChanged(object sender, EventArgs e) => Filtrer();

    private void btnNouvelle_Click(object sender, EventArgs e)
    {
        using var f = new FrmInscriptionDetail();
        if (f.ShowDialog(FindForm()) == DialogResult.OK) Charger();
    }

    private void Executer(Action<int> action)
    {
        int? id = IdSelectionne();
        if (id == null) return;
        try
        {
            action(id.Value);
            Charger();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnValider_Click(object sender, EventArgs e) => Executer(id => _dao.Valider(id));

    private void btnAnnulerInscription_Click(object sender, EventArgs e)
    {
        if (!Outils.Confirmer("Annuler cette inscription ?")) return;
        Executer(id => _dao.Annuler(id));
    }

    private DataRow LigneRecu()
    {
        int? id = IdSelectionne();
        if (id == null) return null;
        try
        {
            return _dao.GetRecu(id.Value);
        }
        catch (Exception ex)
        {
            Outils.Erreur(ex.Message);
            return null;
        }
    }

    private void btnRecu_Click(object sender, EventArgs e)
    {
        var ligne = LigneRecu();
        if (ligne != null) Impression.Apercu(FindForm(), Impression.DocumentRecu(ligne));
    }

    private void btnRecuPdf_Click(object sender, EventArgs e)
    {
        var ligne = LigneRecu();
        if (ligne != null) Impression.Pdf(FindForm(), Impression.DocumentRecu(ligne), "recu_" + ligne["matricule"]);
    }

    private Rapport NouveauRapport() => Rapport.DepuisGrille(dgvInscriptions, "Liste des inscriptions",
        "Année académique " + ReferentielDAO.AnneeActive() + " · " + (_vue?.Count ?? 0) + " inscription(s)");

    private void btnExporter_Click(object sender, EventArgs e) => Exports.CsvDepuisGrille(dgvInscriptions, FindForm(), "inscriptions");

    private void btnImprimer_Click(object sender, EventArgs e) => Impression.Apercu(FindForm(), NouveauRapport().CreerDocument());

    private void btnPdf_Click(object sender, EventArgs e) => Impression.Pdf(FindForm(), NouveauRapport().CreerDocument(), "inscriptions");
}
