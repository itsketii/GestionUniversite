using System.Data;
using GestionUniversite.Models;

namespace GestionUniversite.DataAccess;

public class AnneeDAO
{
    public DataTable Lister() => Sql.Table("SELECT idAnnee, libelle, CONVERT(VARCHAR(10), dateDebut, 103) AS debut, CONVERT(VARCHAR(10), dateFin, 103) AS fin, CASE WHEN estActive = 1 THEN N'Oui' ELSE N'Non' END AS active FROM AnneeAcademique ORDER BY libelle DESC");

    public AnneeAcademique Obtenir(int id)
    {
        var dt = Sql.Table("SELECT * FROM AnneeAcademique WHERE idAnnee = @id", Sql.P("@id", id));
        if (dt.Rows.Count == 0) return null;
        var r = dt.Rows[0];
        return new AnneeAcademique
        {
            IdAnnee = Convert.ToInt32(r["idAnnee"]),
            Libelle = (string)r["libelle"],
            DateDebut = (DateTime)r["dateDebut"],
            DateFin = (DateTime)r["dateFin"],
            EstActive = (bool)r["estActive"]
        };
    }

    public void Enregistrer(AnneeAcademique o)
    {
        if (o.IdAnnee == 0)
            Sql.Executer("SET XACT_ABORT ON; BEGIN TRANSACTION; UPDATE AnneeAcademique SET estActive = 0 WHERE @estActive = 1; INSERT INTO AnneeAcademique (libelle, dateDebut, dateFin, estActive) VALUES (@libelle, @dateDebut, @dateFin, @estActive); COMMIT TRANSACTION;", Sql.P("@libelle", o.Libelle), Sql.P("@dateDebut", o.DateDebut), Sql.P("@dateFin", o.DateFin), Sql.P("@estActive", o.EstActive));
        else
            Sql.Executer("SET XACT_ABORT ON; BEGIN TRANSACTION; UPDATE AnneeAcademique SET estActive = 0 WHERE @estActive = 1 AND idAnnee <> @id; UPDATE AnneeAcademique SET libelle = @libelle, dateDebut = @dateDebut, dateFin = @dateFin, estActive = @estActive WHERE idAnnee = @id; COMMIT TRANSACTION;", Sql.P("@libelle", o.Libelle), Sql.P("@dateDebut", o.DateDebut), Sql.P("@dateFin", o.DateFin), Sql.P("@estActive", o.EstActive), Sql.P("@id", o.IdAnnee));
    }

    public void Supprimer(int id) => Sql.Executer("DELETE FROM AnneeAcademique WHERE idAnnee = @id", Sql.P("@id", id));
}
