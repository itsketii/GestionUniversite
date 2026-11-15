using Microsoft.Data.SqlClient;
using GestionUniversite.DataAccess;
using GestionUniversite.Models;

namespace GestionUniversite.UInterface;

public partial class FrmEnseignantDetail : Form
{
    private readonly EnseignantDAO _dao = new EnseignantDAO();
    private readonly Enseignant _objet;

    public FrmEnseignantDetail() : this(null)
    {
    }

    public FrmEnseignantDetail(Enseignant objet)
    {
        InitializeComponent();
        Theme.Appliquer(this);
        _objet = objet ?? new Enseignant();

        if (_objet.IdEnseignant == 0)
        {
            Text = "Nouvel enseignant";
            lblTitreFiche.Text = Text;

            return;
        }

        Text = "Modifier l'enseignant";
        lblTitreFiche.Text = Text;
        txtMatricule.Text = _objet.Matricule;
        txtEmail.Text = _objet.Email;
        txtNom.Text = _objet.Nom;
        txtPrenoms.Text = _objet.Prenoms;
        txtTelephone.Text = _objet.Telephone;
        txtGrade.Text = _objet.Grade;
        txtSpecialite.Text = _objet.Specialite;
    }

    private static string VideEnNull(string s) => string.IsNullOrWhiteSpace(s) ? null : s.Trim();

    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        lblErreur.Text = "";
        if (string.IsNullOrWhiteSpace(txtMatricule.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtNom.Text) || string.IsNullOrWhiteSpace(txtPrenoms.Text))
        {
            lblErreur.Text = "Les champs marqués * sont obligatoires.";
            return;
        }

        _objet.Matricule = txtMatricule.Text.Trim();
        _objet.Email = txtEmail.Text.Trim();
        _objet.Nom = txtNom.Text.Trim();
        _objet.Prenoms = txtPrenoms.Text.Trim();
        _objet.Telephone = VideEnNull(txtTelephone.Text);
        _objet.Grade = VideEnNull(txtGrade.Text);
        _objet.Specialite = VideEnNull(txtSpecialite.Text);

        try
        {
            _dao.Enregistrer(_objet);
            DialogResult = DialogResult.OK;
        }
        catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
        {
            lblErreur.Text = "Cette valeur existe déjà (code, matricule ou e-mail en double).";
        }
        catch (Exception ex)
        {
            lblErreur.Text = ex.Message;
        }
    }

    private void btnAnnuler_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
}
