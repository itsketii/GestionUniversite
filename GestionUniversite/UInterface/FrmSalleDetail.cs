using Microsoft.Data.SqlClient;
using GestionUniversite.DataAccess;
using GestionUniversite.Models;

namespace GestionUniversite.UInterface;

public partial class FrmSalleDetail : Form
{
    private readonly SalleDAO _dao = new SalleDAO();
    private readonly Salle _objet;

    public FrmSalleDetail() : this(null)
    {
    }

    public FrmSalleDetail(Salle objet)
    {
        InitializeComponent();
        Theme.Appliquer(this);
        _objet = objet ?? new Salle();

        if (_objet.IdSalle == 0)
        {
            Text = "Nouvelle salle";
            lblTitreFiche.Text = Text;
            cboTypeSalle.SelectedIndex = 0;
            return;
        }

        Text = "Modifier la salle";
        lblTitreFiche.Text = Text;
        txtCodeSalle.Text = _objet.CodeSalle;
        numCapacite.Value = _objet.Capacite;
        cboTypeSalle.SelectedItem = _objet.TypeSalle;
        txtBatiment.Text = _objet.Batiment;
    }

    private static string VideEnNull(string s) => string.IsNullOrWhiteSpace(s) ? null : s.Trim();

    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        lblErreur.Text = "";
        if (string.IsNullOrWhiteSpace(txtCodeSalle.Text) || cboTypeSalle.SelectedItem == null)
        {
            lblErreur.Text = "Les champs marqués * sont obligatoires.";
            return;
        }

        _objet.CodeSalle = txtCodeSalle.Text.Trim();
        _objet.Capacite = (int)numCapacite.Value;
        _objet.TypeSalle = cboTypeSalle.SelectedItem.ToString();
        _objet.Batiment = VideEnNull(txtBatiment.Text);

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
