using System.Data;
using GestionUniversite.Models;

namespace GestionUniversite.DataAccess;

public class SalleDAO
{
    public DataTable Lister() => Sql.Table("SELECT idSalle, codeSalle, capacite, typeSalle, batiment FROM Salle ORDER BY codeSalle");

    public Salle Obtenir(int id)
    {
        var dt = Sql.Table("SELECT * FROM Salle WHERE idSalle = @id", Sql.P("@id", id));
        if (dt.Rows.Count == 0) return null;
        var r = dt.Rows[0];
        return new Salle
        {
            IdSalle = Convert.ToInt32(r["idSalle"]),
            CodeSalle = (string)r["codeSalle"],
            Capacite = Convert.ToInt32(r["capacite"]),
            TypeSalle = (string)r["typeSalle"],
            Batiment = r["batiment"] as string
        };
    }

    public void Enregistrer(Salle o)
    {
        if (o.IdSalle == 0)
            Sql.Executer("INSERT INTO Salle (codeSalle, capacite, typeSalle, batiment) VALUES (@codeSalle, @capacite, @typeSalle, @batiment);", Sql.P("@codeSalle", o.CodeSalle), Sql.P("@capacite", o.Capacite), Sql.P("@typeSalle", o.TypeSalle), Sql.P("@batiment", o.Batiment));
        else
            Sql.Executer("UPDATE Salle SET codeSalle = @codeSalle, capacite = @capacite, typeSalle = @typeSalle, batiment = @batiment WHERE idSalle = @id;", Sql.P("@codeSalle", o.CodeSalle), Sql.P("@capacite", o.Capacite), Sql.P("@typeSalle", o.TypeSalle), Sql.P("@batiment", o.Batiment), Sql.P("@id", o.IdSalle));
    }

    public void Supprimer(int id) => Sql.Executer("DELETE FROM Salle WHERE idSalle = @id", Sql.P("@id", id));
}
