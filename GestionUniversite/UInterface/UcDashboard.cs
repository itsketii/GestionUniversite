using System.ComponentModel;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class UcDashboard : UserControl
{
    public UcDashboard()
    {
        InitializeComponent();
    }

    private void UcDashboard_Load(object sender, EventArgs e)
    {
        if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

        lblBonjour.Text = "Bonjour, " + (Session.Utilisateur?.NomComplet ?? "");
        try
        {
            var stats = new StatistiquesDAO();
            lblKpi1Valeur.Text = stats.EtudiantsInscrits().ToString();
            lblKpi2Valeur.Text = stats.ClassesOuvertes().ToString();
            lblKpi3Valeur.Text = stats.SeancesSemaine().ToString();
            lblKpi4Valeur.Text = stats.AbsencesNonJustifiees().ToString();
            dgvSeances.DataSource = stats.ProchainesSeances();
            dgvEffectifs.DataSource = stats.EffectifsParClasse();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
