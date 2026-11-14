using Microsoft.Data.SqlClient;
using GestionUniversite.DataAccess;
using GestionUniversite.Models;

namespace GestionUniversite.UInterface;

public partial class FrmAnneeDetail : Form
{
    private readonly AnneeDAO _dao = new AnneeDAO();
    private readonly AnneeAcademique _objet;

    public FrmAnneeDetail() : this(null)
    {
    }

    public FrmAnneeDetail(AnneeAcademique objet)
    {
        InitializeComponent();
        Theme.Appliquer(this);
        _objet = objet ?? new AnneeAcademique();

        if (_objet.IdAnnee == 0)
        {
            Text = "Nouvelle année académique";
            lblTitreFiche.Text = Text;
            txtLibelle.Text = $"{DateTime.Today.Year}-{DateTime.Today.Year + 1}";
            dtpDateDebut.Value = new DateTime(DateTime.Today.Year, 9, 21);
            dtpDateFin.Value = new DateTime(DateTime.Today.Year + 1, 7, 31);
            chkEstActive.Checked = false;
            return;
        }

        Text = "Modifier l'année académique";
        lblTitreFiche.Text = Text;
        txtLibelle.Text = _objet.Libelle;
        dtpDateDebut.Value = _objet.DateDebut;
        dtpDateFin.Value = _objet.DateFin;
        chkEstActive.Checked = _objet.EstActive;
    }

    private static string VideEnNull(string s) => string.IsNullOrWhiteSpace(s) ? null : s.Trim();

    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        lblErreur.Text = "";
        if (string.IsNullOrWhiteSpace(txtLibelle.Text))
        {
            lblErreur.Text = "Les champs marqués * sont obligatoires.";
            return;
        }
        if (dtpDateFin.Value.Date <= dtpDateDebut.Value.Date)
        {
            lblErreur.Text = "La date de fin doit être après la date de début.";
            return;
        }
        _objet.Libelle = txtLibelle.Text.Trim();
        _objet.DateDebut = dtpDateDebut.Value.Date;
        _objet.DateFin = dtpDateFin.Value.Date;
        _objet.EstActive = chkEstActive.Checked;

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
