using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
        bool ok = DbConnexion.Tester(out string message);
        lblStatut.Text = message;
        lblStatut.ForeColor = ok ? Color.SeaGreen : Color.Firebrick;
        btnCharger.Enabled = ok;
    }

    private void btnCharger_Click(object sender, EventArgs e)
    {
        try
        {
            dgvEtudiants.DataSource = new EtudiantDAO().GetAll();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
