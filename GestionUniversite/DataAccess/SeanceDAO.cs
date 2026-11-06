using System.Data;

namespace GestionUniversite.DataAccess;

public class SeanceDAO
{
    public DataTable ListerSemaine(DateTime debut, DateTime fin, string classe) => Sql.Table(
        "SELECT idSeance, FORMAT(dateSeance, 'ddd dd/MM', 'fr-FR') AS jour, " +
        "CONVERT(VARCHAR(5), heureDebut, 108) + ' - ' + CONVERT(VARCHAR(5), heureFin, 108) AS heure, " +
        "matiere, classe, enseignant, salle, typeSeance, statut " +
        "FROM vEmploiDuTemps WHERE dateSeance BETWEEN @debut AND @fin AND (@classe IS NULL OR classe = @classe) " +
        "ORDER BY dateSeance, heureDebut",
        Sql.P("@debut", debut.Date), Sql.P("@fin", fin.Date), Sql.P("@classe", classe));

    // Les conflits (salle, enseignant, classe, capacité) sont refusés par le trigger de la base
    public void Planifier(int idCours, int idSalle, DateTime date, TimeSpan debut, TimeSpan fin, string type) =>
        Sql.Proc("sp_PlanifierSeance", Sql.P("@idCours", idCours), Sql.P("@idSalle", idSalle),
            Sql.P("@dateSeance", date.Date), Sql.P("@heureDebut", debut), Sql.P("@heureFin", fin), Sql.P("@typeSeance", type));

    public void Annuler(int idSeance) => Sql.Proc("sp_AnnulerSeance", Sql.P("@idSeance", idSeance));
}
