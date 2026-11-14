using Microsoft.Data.SqlClient;
using GestionUniversite.DataAccess;
using GestionUniversite.Models;

namespace GestionUniversite.UInterface;

public partial class FrmUtilisateurDetail : Form
{
    private readonly UtilisateurDAO _dao = new UtilisateurDAO();
    private readonly Utilisateur _objet;

    public FrmUtilisateurDetail() : this(null)
    {
    }

    public FrmUtilisateurDetail(Utilisateur utilisateur)
    {
        InitializeComponent();
        Theme.Appliquer(this);
        _objet = utilisateur ?? new Utilisateur();

        if (_objet.IdUtilisateur == 0)
        {
            Text = "Nouvel utilisateur";
            lblTitreFiche.Text = Text;
            cboRole.SelectedIndex = 0;
            chkActif.Checked = true;
            return;
        }

        Text = "Modifier l'utilisateur";
        lblTitreFiche.Text = Text;
        txtNomComplet.Text = _objet.NomComplet;
        txtEmail.Text = _objet.Email;
        cboRole.SelectedItem = _objet.Role;
        chkActif.Checked = _objet.Actif;
        lblMotDePasse.Text = "Nouveau mot de passe (laisser vide pour le conserver)";
    }

    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        lblErreur.Text = "";
        if (string.IsNullOrWhiteSpace(txtNomComplet.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || cboRole.SelectedItem == null)
        {
            lblErreur.Text = "Le nom, l'e-mail et le rôle sont obligatoires.";
            return;
        }
        string motDePasse = txtMotDePasse.Text;
        if (_objet.IdUtilisateur == 0 && motDePasse == "")
        {
            lblErreur.Text = "Le mot de passe est obligatoire pour un nouvel utilisateur.";
            return;
        }
        if (motDePasse != "" && motDePasse.Length < 8)
        {
            lblErreur.Text = "Le mot de passe doit contenir au moins 8 caractères.";
            return;
        }

        _objet.NomComplet = txtNomComplet.Text.Trim();
        _objet.Email = txtEmail.Text.Trim();
        _objet.Role = cboRole.SelectedItem.ToString();
        _objet.Actif = chkActif.Checked;

        try
        {
            _dao.Enregistrer(_objet, motDePasse);
            DialogResult = DialogResult.OK;
        }
        catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
        {
            lblErreur.Text = "Cette adresse e-mail est déjà utilisée.";
        }
        catch (Exception ex)
        {
            lblErreur.Text = ex.Message;
        }
    }

    private void btnAnnuler_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
}
