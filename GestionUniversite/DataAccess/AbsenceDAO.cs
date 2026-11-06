using System.Data;
using Microsoft.Data.SqlClient;

namespace GestionUniversite.DataAccess;

public class AbsenceDAO
{
    // Séances des 30 derniers jours et des 30 prochains jours
    public DataTable Seances() => Sql.Table(
        "SELECT idSeance, dateSeance, " +
        "CONVERT(VARCHAR(5), dateSeance, 103) + N' ' + CONVERT(VARCHAR(5), heureDebut, 108) + N' | ' + matiere + N' (' + classe + N')' AS libelle " +
        "FROM vEmploiDuTemps WHERE statut <> N'Annulée' " +
        "AND dateSeance BETWEEN DATEADD(day, -30, CAST(GETDATE() AS DATE)) AND DATEADD(day, 30, CAST(GETDATE() AS DATE)) " +
        "ORDER BY dateSeance DESC, heureDebut");

    // Étudiants inscrits (validés) dans la classe de la séance, avec leur absence éventuelle
    public DataTable Appel(int idSeance) => Sql.Table(
        "SELECT e.idEtudiant, e.matricule, e.nom + N' ' + e.prenoms AS etudiant, " +
        "CAST(CASE WHEN a.idAbsence IS NULL THEN 0 ELSE 1 END AS BIT) AS absent, " +
        "CAST(ISNULL(a.justifiee, 0) AS BIT) AS justifiee, ISNULL(a.motif, N'') AS motif " +
        "FROM Seance s JOIN Cours c ON c.idCours = s.idCours " +
        "JOIN Inscription i ON i.idClasse = c.idClasse AND i.statut = N'Validée' " +
        "JOIN Etudiant e ON e.idEtudiant = i.idEtudiant " +
        "LEFT JOIN Absence a ON a.idSeance = s.idSeance AND a.idEtudiant = e.idEtudiant " +
        "WHERE s.idSeance = @idSeance ORDER BY e.nom, e.prenoms",
        Sql.P("@idSeance", idSeance));

    public void EnregistrerAppel(int idSeance, DataTable appel)
    {
        using var cn = DbConnexion.Creer();
        cn.Open();
        using var tx = cn.BeginTransaction();
        try
        {
            foreach (DataRow r in appel.Rows)
            {
                bool absent = (bool)r["absent"];
                using var cmd = new SqlCommand(absent ? "sp_EnregistrerAbsence" : "SP_Absence_Supprimer", cn, tx)
                { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@idSeance", idSeance);
                cmd.Parameters.AddWithValue("@idEtudiant", (int)r["idEtudiant"]);
                if (absent)
                {
                    string motif = r["motif"] as string;
                    cmd.Parameters.AddWithValue("@justifiee", (bool)r["justifiee"]);
                    cmd.Parameters.AddWithValue("@motif", string.IsNullOrWhiteSpace(motif) ? (object)DBNull.Value : motif.Trim());
                }
                cmd.ExecuteNonQuery();
            }
            tx.Commit();
        }
        catch
        {
            try { tx.Rollback(); } catch { }
            throw;
        }
    }
}
