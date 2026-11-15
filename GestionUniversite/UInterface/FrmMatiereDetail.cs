using Microsoft.Data.SqlClient;
using GestionUniversite.DataAccess;
using GestionUniversite.Models;

namespace GestionUniversite.UInterface;

public partial class FrmMatiereDetail : Form
{
    private readonly MatiereDAO _dao = new MatiereDAO();
    private readonly Matiere _objet;

    public FrmMatiereDetail() : this(null)
    {
    }

    public FrmMatiereDetail(Matiere objet)
    {
        InitializeComponent();
        Theme.Appliquer(this);
        _objet = objet ?? new Matiere();

        if (_objet.IdMatiere == 0)
        {
            Text = "Nouvelle matière";
            lblTitreFiche.Text = Text;

            return;
        }

        Text = "Modifier la matière";
        lblTitreFiche.Text = Text;
        txtCodeMatiere.Text = _objet.CodeMatiere;
        numCredits.Value = _objet.Credits;
        txtIntitule.Text = _objet.Intitule;
    }

    private static string VideEnNull(string s) => string.IsNullOrWhiteSpace(s) ? null : s.Trim();

    private void btnEnregistrer_Click(object sender, EventArgs e)
    {
        lblErreur.Text = "";
        if (string.IsNullOrWhiteSpace(txtCodeMatiere.Text) || string.IsNullOrWhiteSpace(txtIntitule.Text))
        {
            lblErreur.Text = "Les champs marqués * sont obligatoires.";
            return;
        }

        _objet.CodeMatiere = txtCodeMatiere.Text.Trim();
        _objet.Credits = (int)numCredits.Value;
        _objet.Intitule = txtIntitule.Text.Trim();

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
