using System.Globalization;
using FontAwesome.Sharp;
using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class FrmMain : Form
{
    private readonly Dictionary<string, (Func<UserControl> Page, IconButton Bouton, string Titre)> _pages =
        new Dictionary<string, (Func<UserControl>, IconButton, string)>();
    private string _courant = "Dashboard";

    public FrmMain()
    {
        InitializeComponent();
        WindowState = FormWindowState.Maximized;

        _pages["Dashboard"] = (() => new UcDashboard(), btnDashboard, "Tableau de bord");
        _pages["Statistiques"] = (() => new UcStatistiques(), btnStatistiques, "Statistiques");
        _pages["Etudiants"] = (() => new UcEtudiants(), btnEtudiants, "Étudiants");
        _pages["Inscriptions"] = (() => new UcInscriptions(), btnInscriptions, "Inscriptions");
        _pages["Classes"] = (() => new UcClasses(), btnClasses, "Classes et cours");
        _pages["Planification"] = (() => new UcPlanification(), btnPlanification, "Planification");
        _pages["Absences"] = (() => new UcAbsences(), btnAbsences, "Absences");
        _pages["Enseignants"] = (() => new UcEnseignants(), btnEnseignants, "Enseignants");
        _pages["Matieres"] = (() => new UcMatieres(), btnMatieres, "Matières");
        _pages["Salles"] = (() => new UcSalles(), btnSalles, "Salles");
        _pages["Structure"] = (() => new UcStructure(), btnStructure, "Structure académique");
        _pages["Utilisateurs"] = (() => new UcUtilisateurs(), btnUtilisateurs, "Utilisateurs");
        _pages["Parametres"] = (() => new UcParametres(), btnParametres, "Paramètres");

        foreach (var entree in _pages)
        {
            string cle = entree.Key;
            entree.Value.Bouton.Click += (s, e) => Aller(cle);
        }
    }

    private void FrmMain_Load(object sender, EventArgs e)
    {
        var fr = new CultureInfo("fr-FR");
        lblDate.Text = fr.TextInfo.ToTitleCase(DateTime.Now.ToString("dddd d MMMM yyyy", fr));
        lblUtilisateur.Text = Session.Utilisateur?.NomComplet ?? "";
        lblRole.Text = Session.Utilisateur?.Role ?? "";
        lblInitiales.Text = Outils.Initiales(Session.Utilisateur?.NomComplet);
        try { lblAnnee.Text = "Année " + ReferentielDAO.AnneeActive(); }
        catch { lblAnnee.Text = "Année non disponible"; }

        AppliquerThemeEcran();
        Aller("Dashboard");
    }

    // Affiche une page dans la zone centrale (utilisé aussi par les boutons des pages)
    public void Aller(string cle)
    {
        if (!_pages.TryGetValue(cle, out var info)) return;
        _courant = cle;
        foreach (var entree in _pages) Style(entree.Value.Bouton, entree.Key == cle);

        foreach (Control ancienne in pnlContenu.Controls.Cast<Control>().ToList()) ancienne.Dispose();
        var page = info.Page();
        page.Dock = DockStyle.Fill;
        pnlContenu.Controls.Add(page);
        Theme.Appliquer(page);
        lblPage.Text = info.Titre;
    }

    private static void Style(IconButton bouton, bool actif)
    {
        bouton.BackColor = actif ? Theme.Primaire : Theme.MenuFond;
        Color couleur = actif ? Color.White : Theme.MenuTexte;
        bouton.ForeColor = couleur;
        bouton.IconColor = couleur;
    }

    // À appeler après un changement de thème
    public void AppliquerThemeEcran()
    {
        Theme.Appliquer(this);
        foreach (var entree in _pages) Style(entree.Value.Bouton, entree.Key == _courant);
        Style(btnDeconnexion, false);
        btnTheme.IconChar = Theme.Sombre ? IconChar.Sun : IconChar.Moon;
        Invalidate(true);
    }

    private void btnTheme_Click(object sender, EventArgs e)
    {
        Theme.Basculer();
        AppliquerThemeEcran();
    }

    private void btnDeconnexion_Click(object sender, EventArgs e)
    {
        Session.Utilisateur = null;
        Application.Restart();
    }
}
