namespace GestionUniversite.UInterface;

// Droits d'accès selon le rôle de l'utilisateur connecté
public static class Droits
{
    public const string Admin = "Administrateur";
    public const string Scolarite = "Scolarité";
    public const string Enseignant = "Enseignant";

    private static readonly string[] Tous = { Admin, Scolarite, Enseignant };
    private static readonly string[] AdminEtScolarite = { Admin, Scolarite };

    // Qui peut ouvrir l'écran
    private static readonly Dictionary<string, string[]> Acces = new Dictionary<string, string[]>
    {
        ["Dashboard"] = Tous,
        ["Statistiques"] = Tous,
        ["Etudiants"] = Tous,
        ["Inscriptions"] = AdminEtScolarite,
        ["Classes"] = Tous,
        ["Planification"] = Tous,
        ["Absences"] = Tous,
        ["Enseignants"] = AdminEtScolarite,
        ["Matieres"] = AdminEtScolarite,
        ["Salles"] = AdminEtScolarite,
        ["Structure"] = AdminEtScolarite,
        ["Utilisateurs"] = new[] { Admin },
        ["Parametres"] = Tous
    };

    // Qui peut ajouter, modifier, supprimer ou importer dans l'écran
    private static readonly Dictionary<string, string[]> Ecriture = new Dictionary<string, string[]>
    {
        ["Etudiants"] = AdminEtScolarite,
        ["Inscriptions"] = AdminEtScolarite,
        ["Classes"] = AdminEtScolarite,
        ["Planification"] = AdminEtScolarite,
        ["Absences"] = Tous,
        ["Enseignants"] = AdminEtScolarite,
        ["Matieres"] = AdminEtScolarite,
        ["Salles"] = AdminEtScolarite,
        ["Structure"] = new[] { Admin },
        ["Utilisateurs"] = new[] { Admin }
    };

    // Boutons d'écriture masqués en lecture seule (d'après le début de leur nom)
    private static readonly string[] PrefixesEcriture =
    {
        "btnNouv", "btnModifier", "btnSupprimer", "btnAjouter", "btnRetirer", "btnImporter",
        "btnValider", "btnAnnuler", "btnPlanifier", "btnEnregistrerAppel"
    };

    public static string Role => Session.Utilisateur?.Role ?? "";

    public static bool EstAdmin => Role == Admin;

    public static bool PeutAcceder(string module) => Acces.TryGetValue(module, out var roles) && roles.Contains(Role);

    public static bool PeutEcrire(string module) => Ecriture.TryGetValue(module, out var roles) && roles.Contains(Role);

    // Passe une page en lecture seule si le rôle n'a pas le droit d'écrire
    public static void AppliquerEcriture(Control page, string module)
    {
        if (PeutEcrire(module)) return;
        MasquerBoutons(page);

        var sousTitre = page.Controls.Find("lblSousTitre", true).FirstOrDefault();
        if (sousTitre != null) sousTitre.Text += " (lecture seule)";

        foreach (var control in page.Controls.Find("dgvAppel", true))
            if (control is DataGridView grille) grille.ReadOnly = true;
    }

    private static void MasquerBoutons(Control parent)
    {
        foreach (Control enfant in parent.Controls)
        {
            if (enfant is Button bouton && PrefixesEcriture.Any(p => bouton.Name.StartsWith(p)))
                bouton.Visible = false;
            MasquerBoutons(enfant);
        }
    }
}
