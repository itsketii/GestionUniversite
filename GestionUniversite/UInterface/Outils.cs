using System.ComponentModel;
using System.Data;

namespace GestionUniversite.UInterface;

public static class Outils
{
    // Vrai quand le code s'exécute dans le designer de Visual Studio (pas d'accès base)
    public static bool EstDesigner => LicenseManager.UsageMode == LicenseUsageMode.Designtime;

    public static void Lier(ComboBox cbo, DataTable donnees, string affichage, string valeur, bool selectionnerPremier = true)
    {
        cbo.DisplayMember = affichage;
        cbo.ValueMember = valeur;
        cbo.DataSource = donnees;
        cbo.SelectedIndex = selectionnerPremier && donnees.Rows.Count > 0 ? 0 : -1;
    }

    public static List<KeyValuePair<string, double>> EnListe(DataTable table, string libelle = "libelle", string valeur = "valeur")
    {
        return table.Rows.Cast<DataRow>()
            .Select(r => new KeyValuePair<string, double>(Convert.ToString(r[libelle]), Convert.ToDouble(r[valeur])))
            .ToList();
    }

    // Prépare un texte de recherche pour un RowFilter (retire les caractères spéciaux)
    public static string Nettoyer(string texte)
    {
        string t = new string((texte ?? "").Trim().Where(c => "[]*%".IndexOf(c) < 0).ToArray());
        return t.Replace("'", "''");
    }

    public static string Initiales(string nom)
    {
        var mots = (nom ?? "").Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (mots.Length == 0) return "?";
        if (mots.Length == 1) return mots[0].Substring(0, 1).ToUpper();
        return (mots[0].Substring(0, 1) + mots[mots.Length - 1].Substring(0, 1)).ToUpper();
    }

    public static void Erreur(string message) =>
        MessageBox.Show(message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

    public static void Info(string message) =>
        MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

    public static bool Confirmer(string question) =>
        MessageBox.Show(question, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
}
