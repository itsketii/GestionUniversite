using Microsoft.Data.SqlClient;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class FrmCoursDetail : Form
{
    private readonly int _idClasse;

    public FrmCoursDetail() : this(0)
    {
    }

    public FrmCoursDetail(int idClasse)
    {
        InitializeComponent();
        Theme.Appliquer(this);
        _idClasse = idClasse;
        if (Outils.EstDesigner) return;
        Outils.Lier(cboMatiere, ReferentielDAO.Matieres(), "libelle", "idMatiere");
        Outils.Lier(cboEnseignant, ReferentielDAO.Enseignants(), "libelle", "idEnseignant");
    }

    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        lblErreur.Text = "";
        if (cboMatiere.SelectedValue == null || cboEnseignant.SelectedValue == null)
        {
            lblErreur.Text = "Choisissez la matière et l'enseignant.";
            return;
        }

        try
        {
            new ClasseDAO().AjouterCours(_idClasse, (int)cboMatiere.SelectedValue, (int)cboEnseignant.SelectedValue, (int)numVolume.Value);
            DialogResult = DialogResult.OK;
        }
        catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
        {
            lblErreur.Text = "Cette matière est déjà associée à cette classe.";
        }
        catch (Exception ex)
        {
            lblErreur.Text = ex.Message;
        }
    }

    private void btnAnnuler_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
}
