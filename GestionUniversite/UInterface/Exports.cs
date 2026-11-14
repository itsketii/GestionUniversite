using System.Diagnostics;
using System.Text;

namespace GestionUniversite.UInterface;

public static class Exports
{
    // Exporte les colonnes visibles d'une grille en CSV (s'ouvre directement dans Excel)
    public static void CsvDepuisGrille(DataGridView grille, IWin32Window parent, string nomFichier)
    {
        using var dlg = new SaveFileDialog
        {
            Filter = "Fichier CSV pour Excel (*.csv)|*.csv",
            FileName = nomFichier + "_" + DateTime.Now.ToString("yyyyMMdd") + ".csv"
        };
        if (dlg.ShowDialog(parent) != DialogResult.OK) return;

        try
        {
            var colonnes = grille.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).OrderBy(c => c.DisplayIndex).ToList();
            var sb = new StringBuilder();
            sb.AppendLine(string.Join(";", colonnes.Select(c => Champ(c.HeaderText))));
            foreach (DataGridViewRow ligne in grille.Rows)
                sb.AppendLine(string.Join(";", colonnes.Select(c => Champ(Convert.ToString(ligne.Cells[c.Index].FormattedValue)))));
            File.WriteAllText(dlg.FileName, sb.ToString(), new UTF8Encoding(true));
            Proposer(dlg.FileName, "Export terminé.");
        }
        catch (Exception ex)
        {
            Outils.Erreur("Export impossible : " + ex.Message);
        }
    }

    public static void Proposer(string fichier, string message)
    {
        if (MessageBox.Show(message + "\n\nAfficher le fichier dans l'explorateur ?", "Export", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            Process.Start("explorer.exe", "/select,\"" + fichier + "\"");
    }

    private static string Champ(string valeur)
    {
        valeur = valeur ?? "";
        if (valeur.IndexOfAny(new[] { ';', '"', '\n', '\r' }) >= 0)
            valeur = "\"" + valeur.Replace("\"", "\"\"") + "\"";
        return valeur;
    }
}
