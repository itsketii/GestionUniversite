using GestionUniversite.DataAccess;

namespace GestionUniversite.UInterface;

public partial class UcParametres : UserControl
{
    public UcParametres()
    {
        InitializeComponent();
    }

    private void UcParametres_Load(object sender, EventArgs e)
    {
        if (Outils.EstDesigner) return;
        lblNomCompte.Text = Session.Utilisateur?.NomComplet ?? "";
        lblEmailCompte.Text = Session.Utilisateur?.Email ?? "";
        lblRoleCompte.Text = "Rôle : " + (Session.Utilisateur?.Role ?? "");
        lblServeur.Text = "Serveur : " + DbConnexion.Serveur;
        lblBase.Text = "Base de données : " + DbConnexion.Base;
        txtEtablissement.Text = Parametres.Etablissement;
        StyleBoutons();
    }

    private void StyleBoutons()
    {
        btnClair.BackColor = Theme.Sombre ? Theme.Secondaire : Theme.Primaire;
        btnClair.ForeColor = Theme.Sombre ? Theme.Texte : Color.White;
        btnSombre.BackColor = Theme.Sombre ? Theme.Primaire : Theme.Secondaire;
        btnSombre.ForeColor = Theme.Sombre ? Color.White : Theme.Texte;
    }

    private void ChangerTheme(bool sombre)
    {
        Theme.Definir(sombre);
        if (FindForm() is FrmMain principal) principal.AppliquerThemeEcran();
        StyleBoutons();
    }

    private void btnClair_Click(object sender, EventArgs e) => ChangerTheme(false);

    private void btnSombre_Click(object sender, EventArgs e) => ChangerTheme(true);

    private void btnEnregistrerEtab_Click(object sender, EventArgs e)
    {
        string nom = txtEtablissement.Text.Trim();
        Parametres.Etablissement = nom == "" ? "Institut Ivoirien de Technologie" : nom;
        Parametres.Enregistrer();
        Outils.Info("Nom de l'établissement enregistré.");
    }

    private void btnMotDePasse_Click(object sender, EventArgs e)
    {
        using var f = new FrmMotDePasse();
        if (f.ShowDialog(FindForm()) == DialogResult.OK) Outils.Info("Mot de passe modifié.");
    }

    private void btnTester_Click(object sender, EventArgs e)
    {
        bool ok = DbConnexion.Tester(out string message);
        lblEtat.Text = message;
        lblEtat.ForeColor = ok ? Color.FromArgb(30, 107, 58) : Color.FromArgb(179, 38, 30);
    }
}
