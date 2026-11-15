using System.Data;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class UcStructure : UserControl
{
    private readonly FiliereDAO _filieres = new FiliereDAO();
    private readonly NiveauDAO _niveaux = new NiveauDAO();
    private readonly AnneeDAO _annees = new AnneeDAO();

    public UcStructure()
    {
        InitializeComponent();
    }

    private void UcStructure_Load(object sender, EventArgs e)
    {
        if (Outils.EstDesigner) return;
        ChargerFilieres();
        ChargerNiveaux();
        ChargerAnnees();
    }

    private void Securise(Action action)
    {
        try
        {
            action();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private static int? Id(DataGridView grille, string colonne)
    {
        if (grille.CurrentRow?.DataBoundItem is DataRowView ligne) return (int)ligne[colonne];
        return null;
    }

    private void Dialogue(Form formulaire, Action recharger)
    {
        using (formulaire)
        {
            if (formulaire.ShowDialog(FindForm()) == DialogResult.OK) recharger();
        }
    }

    private void Supprimer(int? id, Action<int> suppression, Action recharger)
    {
        if (id == null) return;
        if (!Outils.Confirmer("Supprimer l'élément sélectionné ?")) return;
        try
        {
            suppression(id.Value);
            recharger();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Suppression impossible : cet élément est utilisé ailleurs dans l’application.\n\n" + ex.Message,
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void ChargerFilieres() => Securise(() => dgvFilieres.DataSource = _filieres.Lister());
    private void ChargerNiveaux() => Securise(() => dgvNiveaux.DataSource = _niveaux.Lister());
    private void ChargerAnnees() => Securise(() => dgvAnnees.DataSource = _annees.Lister());

    private void btnAjouterFiliere_Click(object sender, EventArgs e) => Dialogue(new FrmFiliereDetail(), ChargerFilieres);
    private void btnModifierFiliere_Click(object sender, EventArgs e)
    {
        int? id = Id(dgvFilieres, "idFiliere");
        if (id != null) Securise(() => Dialogue(new FrmFiliereDetail(_filieres.Obtenir(id.Value)), ChargerFilieres));
    }
    private void btnSupprimerFiliere_Click(object sender, EventArgs e) => Supprimer(Id(dgvFilieres, "idFiliere"), _filieres.Supprimer, ChargerFilieres);

    private void btnAjouterNiveau_Click(object sender, EventArgs e) => Dialogue(new FrmNiveauDetail(), ChargerNiveaux);
    private void btnModifierNiveau_Click(object sender, EventArgs e)
    {
        int? id = Id(dgvNiveaux, "idNiveau");
        if (id != null) Securise(() => Dialogue(new FrmNiveauDetail(_niveaux.Obtenir(id.Value)), ChargerNiveaux));
    }
    private void btnSupprimerNiveau_Click(object sender, EventArgs e) => Supprimer(Id(dgvNiveaux, "idNiveau"), _niveaux.Supprimer, ChargerNiveaux);

    private void btnAjouterAnnee_Click(object sender, EventArgs e) => Dialogue(new FrmAnneeDetail(), ChargerAnnees);
    private void btnModifierAnnee_Click(object sender, EventArgs e)
    {
        int? id = Id(dgvAnnees, "idAnnee");
        if (id != null) Securise(() => Dialogue(new FrmAnneeDetail(_annees.Obtenir(id.Value)), ChargerAnnees));
    }
    private void btnSupprimerAnnee_Click(object sender, EventArgs e) => Supprimer(Id(dgvAnnees, "idAnnee"), _annees.Supprimer, ChargerAnnees);
}
