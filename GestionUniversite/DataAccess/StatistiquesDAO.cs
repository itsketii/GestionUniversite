using System.Data;
using Microsoft.Data.SqlClient;

namespace GestionUniversite.DataAccess;

// Lectures pour le tableau de bord
public class StatistiquesDAO
{
    private const string AnneeActive = "(SELECT idAnnee FROM AnneeAcademique WHERE estActive = 1)";

    public int EtudiantsInscrits() =>
        Scalaire($"SELECT COUNT(*) FROM Inscription WHERE statut = N'Validée' AND idAnnee = {AnneeActive}");

    public int ClassesOuvertes() =>
        Scalaire($"SELECT COUNT(*) FROM Classe WHERE idAnnee = {AnneeActive}");

    public int SeancesSemaine() =>
        Scalaire("SELECT COUNT(*) FROM Seance WHERE statut <> N'Annulée' " +
                 "AND dateSeance BETWEEN CAST(GETDATE() AS DATE) AND DATEADD(day, 7, CAST(GETDATE() AS DATE))");

    public int AbsencesNonJustifiees() =>
        Scalaire("SELECT COUNT(*) FROM Absence WHERE justifiee = 0");

    public DataTable ProchainesSeances() =>
        Table("SELECT TOP 10 CONVERT(VARCHAR(5), dateSeance, 103) AS jour, " +
              "CONVERT(VARCHAR(5), heureDebut, 108) + ' - ' + CONVERT(VARCHAR(5), heureFin, 108) AS heure, " +
              "matiere, classe, salle, typeSeance " +
              "FROM vEmploiDuTemps WHERE statut <> N'Annulée' AND dateSeance >= CAST(GETDATE() AS DATE) " +
              "ORDER BY dateSeance, heureDebut");

    public DataTable EffectifsParClasse() =>
        Table("SELECT libelle, effectif FROM vEffectifClasse " +
              "WHERE anneeAcademique = (SELECT libelle FROM AnneeAcademique WHERE estActive = 1) ORDER BY libelle");

    private static int Scalaire(string sql)
    {
        using var cn = DbConnexion.Creer();
        using var cmd = new SqlCommand(sql, cn);
        cn.Open();
        return Convert.ToInt32(cmd.ExecuteScalar());
    }

    private static DataTable Table(string sql)
    {
        var dt = new DataTable();
        using var cn = DbConnexion.Creer();
        using var da = new SqlDataAdapter(sql, cn);
        da.Fill(dt);
        return dt;
    }
}
