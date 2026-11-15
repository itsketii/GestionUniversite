using Microsoft.Data.SqlClient;
using GestionUniversite.DataAccess;
using GestionUniversite.Models;

namespace GestionUniversite.UInterface;

public partial class FrmNiveauDetail : Form
{
    private readonly NiveauDAO _dao = new NiveauDAO();
    private readonly Niveau _objet;

    public FrmNiveauDetail() : this(null)
    {
    }

    public FrmNiveauDetail(Niveau objet)
    {
        InitializeComponent();
        Theme.Appliquer(this);
        _objet = objet ?? new Niveau();

        if (_objet.IdNiveau == 0)
        {
            Text = "Nouveau niveau";
            lblTitreFiche.Text = Text;

            return;
        }

        Text = "Modifier le niveau";
        lblTitreFiche.Text = Text;
        txtCodeNiveau.Text = _objet.CodeNiveau;
        txtLibelle.Text = _objet.Libelle;
    }

    private static string VideEnNull(string s) => string.IsNullOrWhiteSpace(s) ? null : s.Trim();

    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        lblErreur.Text = "";
        if (string.IsNullOrWhiteSpace(txtCodeNiveau.Text) || string.IsNullOrWhiteSpace(txtLibelle.Text))
        {
            lblErreur.Text = "Les champs marqués * sont obligatoires.";
            return;
        }

        _objet.CodeNiveau = txtCodeNiveau.Text.Trim();
        _objet.Libelle = txtLibelle.Text.Trim();

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
