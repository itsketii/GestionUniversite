using Microsoft.Data.SqlClient;
using GestionUniversite.DataAccess;
using GestionUniversite.Models;

namespace GestionUniversite.UInterface;

public partial class FrmEtudiantDetail : Form
{
    private readonly EtudiantDAO _dao = new EtudiantDAO();
    private readonly Etudiant _etudiant;

    public FrmEtudiantDetail() : this(null)
    {
    }

    public FrmEtudiantDetail(Etudiant etudiant)
    {
        InitializeComponent();
        Theme.Appliquer(this);
        dtpNaissance.MaxDate = DateTime.Today;
        _etudiant = etudiant ?? new Etudiant();

        if (_etudiant.IdEtudiant == 0)
        {
            Text = "Nouvel étudiant";
            dtpNaissance.Value = new DateTime(2005, 1, 1);
            return;
        }

        Text = "Modifier l'étudiant";
        txtMatricule.Text = _etudiant.Matricule;
        txtNom.Text = _etudiant.Nom;
        txtPrenoms.Text = _etudiant.Prenoms;
        dtpNaissance.Value = _etudiant.DateNaissance;
        txtLieu.Text = _etudiant.LieuNaissance;
        cboSexe.SelectedItem = _etudiant.Sexe;
        txtEmail.Text = _etudiant.Email;
        txtTelephone.Text = _etudiant.Telephone;
        txtAdresse.Text = _etudiant.Adresse;
    }

    private static string VideEnNull(string s) => string.IsNullOrWhiteSpace(s) ? null : s.Trim();

    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        lblErreur.Text = "";
        if (string.IsNullOrWhiteSpace(txtMatricule.Text) || string.IsNullOrWhiteSpace(txtNom.Text) ||
            string.IsNullOrWhiteSpace(txtPrenoms.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || cboSexe.SelectedItem == null)
        {
            lblErreur.Text = "Les champs marqués * sont obligatoires.";
            return;
        }

        _etudiant.Matricule = txtMatricule.Text.Trim();
        _etudiant.Nom = txtNom.Text.Trim();
        _etudiant.Prenoms = txtPrenoms.Text.Trim();
        _etudiant.DateNaissance = dtpNaissance.Value.Date;
        _etudiant.LieuNaissance = VideEnNull(txtLieu.Text);
        _etudiant.Sexe = cboSexe.SelectedItem.ToString();
        _etudiant.Email = txtEmail.Text.Trim();
        _etudiant.Telephone = VideEnNull(txtTelephone.Text);
        _etudiant.Adresse = VideEnNull(txtAdresse.Text);

        try
        {
            if (_etudiant.IdEtudiant == 0) _dao.Create(_etudiant);
            else _dao.Update(_etudiant);
            DialogResult = DialogResult.OK;
        }
        catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
        {
            lblErreur.Text = "Ce matricule ou cet e-mail existe déjà.";
        }
        catch (Exception ex)
        {
            lblErreur.Text = ex.Message;
        }
    }

    private void btnAnnuler_Click(object sender, EventArgs e) => DialogResult = DialogResult.Cancel;
}
