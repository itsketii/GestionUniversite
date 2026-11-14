namespace GestionUniversite.UInterface;

// Réglages de l'application enregistrés pour chaque utilisateur Windows
public static class Parametres
{
    private static string Dossier => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GestionUniversite");
    private static string Fichier => Path.Combine(Dossier, "parametres.txt");

    public static string Mode { get; set; } = "clair";
    public static string Etablissement { get; set; } = "Institut Ivoirien de Technologie";

    public static void Charger()
    {
        try
        {
            if (!File.Exists(Fichier)) return;
            foreach (var ligne in File.ReadAllLines(Fichier))
            {
                int i = ligne.IndexOf('=');
                if (i < 0) continue;
                string cle = ligne.Substring(0, i).Trim();
                string valeur = ligne.Substring(i + 1).Trim();
                if (cle == "theme" && (valeur == "clair" || valeur == "sombre")) Mode = valeur;
                else if (cle == "etablissement" && valeur != "") Etablissement = valeur;
            }
        }
        catch
        {
            // Réglages illisibles : on garde les valeurs par défaut
        }
    }

    public static void Enregistrer()
    {
        try
        {
            Directory.CreateDirectory(Dossier);
            File.WriteAllLines(Fichier, new[] { "theme=" + Mode, "etablissement=" + Etablissement });
        }
        catch
        {
            // Dossier non accessible : les réglages ne seront pas conservés
        }
    }
}
