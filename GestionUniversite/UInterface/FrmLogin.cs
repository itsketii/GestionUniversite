using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class FrmLogin : Form
{
    public FrmLogin()
    {
        InitializeComponent();
    }

    private void btnConnexion_Click(object sender, EventArgs e)
    {
        lblErreur.Text = "";
        string email = txtEmail.Text.Trim();

        if (email == "" || txtMotDePasse.Text == "")
        {
            lblErreur.Text = "Renseignez l’e-mail et le mot de passe.";
            return;
        }

        try
        {
            var utilisateur = new UtilisateurDAO().Authentifier(email, txtMotDePasse.Text);
            if (utilisateur == null)
            {
                lblErreur.Text = "Identifiants incorrects.";
                return;
            }
            Session.Utilisateur = utilisateur;
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex)
        {
            lblErreur.Text = "Erreur de connexion à la base : " + ex.Message;
        }
    }

    private void boutonArrondi1_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void picCampus_Click(object sender, EventArgs e)
    {

    }
}
