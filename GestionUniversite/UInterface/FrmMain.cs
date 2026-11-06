namespace GestionUniversite.UInterface;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
    }

    private Button[] BoutonsMenu => new[]
    {
        btnDashboard, btnEtudiants, btnInscriptions, btnClasses, btnPlanification, btnAbsences
    };

    private void FrmMain_Load(object sender, EventArgs e)
    {
        lblUtilisateur.Text = Session.Utilisateur?.NomComplet ?? "";
        Afficher(new UcDashboard(), btnDashboard);
    }

    // Charge une page (UserControl) dans la zone centrale et met le menu en surbrillance
    private void Afficher(UserControl page, Button bouton)
    {
        foreach (var b in BoutonsMenu) b.BackColor = Theme.MenuFond;
        bouton.BackColor = Theme.Primaire;

        foreach (Control ancienne in pnlContenu.Controls.Cast<Control>().ToList()) ancienne.Dispose();
        page.Dock = DockStyle.Fill;
        pnlContenu.Controls.Add(page);
    }

    private void btnDashboard_Click(object sender, EventArgs e) => Afficher(new UcDashboard(), btnDashboard);
    private void btnEtudiants_Click(object sender, EventArgs e) => Afficher(new UcEtudiants(), btnEtudiants);
    private void btnInscriptions_Click(object sender, EventArgs e) => Afficher(new UcInscriptions(), btnInscriptions);
    private void btnClasses_Click(object sender, EventArgs e) => Afficher(new UcClasses(), btnClasses);
    private void btnPlanification_Click(object sender, EventArgs e) => Afficher(new UcPlanification(), btnPlanification);
    private void btnAbsences_Click(object sender, EventArgs e) => Afficher(new UcAbsences(), btnAbsences);

    private void btnDeconnexion_Click(object sender, EventArgs e)
    {
        Session.Utilisateur = null;
        Application.Restart();
    }

    private void lblLogo_Click(object sender, EventArgs e)
    {

    }
}
