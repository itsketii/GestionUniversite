using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class FrmMotDePasse : Form
{
    public FrmMotDePasse()
    {
        InitializeComponent();
        Theme.Appliquer(this);
    }

    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        lblErreur.Text = "";
        if (txtAncien.Text == "" || txtNouveau.Text == "" || txtConfirmer.Text == "")
        {
            lblErreur.Text = "Tous les champs sont obligatoires.";
            return;
        }
        if (txtNouveau.Text.Length < 8)
        {
            lblErreur.Text = "Le nouveau mot de passe doit contenir au moins 8 caractères.";
            return;
        }
        if (txtNouveau.Text != txtConfirmer.Text)
        {
            lblErreur.Text = "La confirmation ne correspond pas au nouveau mot de passe.";
            return;
        }

        try
        {
            bool ok = new UtilisateurDAO().ChangerMotDePasse(Session.Utilisateur.IdUtilisateur, txtAncien.Text, txtNouveau.Text);
            if (!ok)
            {
                lblErreur.Text = "Le mot de passe actuel est incorrect.";
                return;
            }
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            lblErreur.Text = ex.Message;
        }
    }

    private void btnAnnuler_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
}
