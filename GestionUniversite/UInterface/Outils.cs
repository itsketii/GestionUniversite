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
}
