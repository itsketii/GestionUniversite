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
        if (Outils.EstDesigner) return;
        lblBonjour.Text = "Bonjour, " + (Session.Utilisateur?.NomComplet ?? "");
        try
        {
            var stats = new StatistiquesDAO();
            int inscrits = stats.EtudiantsInscrits();
            int classes = stats.ClassesOuvertes();
            int seances = stats.SeancesSemaine();

            carteInscrits.Valeur = inscrits.ToString();
            carteAttente.Valeur = stats.InscriptionsEnAttente().ToString();
            carteClasses.Valeur = classes.ToString();
            carteSeances.Valeur = seances.ToString();
            carteAbsences.Valeur = stats.AbsencesNonJustifiees().ToString();
            lblDetail.Text = $"{inscrits} étudiants inscrits · {classes} classes · {seances} séances cette semaine";
            lblSousTitre.Text = "Année académique " + ReferentielDAO.AnneeActive() + " : vue d’ensemble";

            grFiliere.Donnees = Outils.EnListe(stats.InscriptionsParFiliere());
            grStatuts.Donnees = Outils.EnListe(stats.StatutsInscription());
            grClasses.Donnees = Outils.EnListe(stats.EffectifParClasse());
            dgvSeances.DataSource = stats.ProchainesSeances();
            dgvInscriptions.DataSource = stats.DernieresInscriptions();
        }
        catch (Exception ex)
        {
            Outils.Erreur(ex.Message);
        }
    }

    private void btnNouvelleInscription_Click(object sender, EventArgs e) => (FindForm() as FrmMain)?.Aller("Inscriptions");

    private void btnVoirStats_Click(object sender, EventArgs e) => (FindForm() as FrmMain)?.Aller("Statistiques");
}
