using Microsoft.Data.SqlClient;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class FrmInscriptionDetail : Form
{
    public FrmInscriptionDetail()
    {
        InitializeComponent();
        Theme.Appliquer(this);
        if (Outils.EstDesigner) return;
        Outils.Lier(cboEtudiant, ReferentielDAO.Etudiants(), "libelle", "idEtudiant", false);
        Outils.Lier(cboClasse, ReferentielDAO.ClassesActives(), "libelle", "idClasse");
    }

    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        lblErreur.Text = "";
        if (cboEtudiant.SelectedValue == null || cboClasse.SelectedValue == null)
        {
            lblErreur.Text = "Choisissez un étudiant et une classe.";
            return;
        }

        try
        {
            new InscriptionDAO().Inscrire((int)cboEtudiant.SelectedValue, (int)cboClasse.SelectedValue,
                numFrais.Value, chkValider.Checked);
            DialogResult = DialogResult.OK;
        }
        catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
        {
            lblErreur.Text = "Cet étudiant est déjà inscrit pour cette année.";
        }
        catch (Exception ex)
        {
            lblErreur.Text = ex.Message;
        }
    }

    private void btnAnnuler_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
}
