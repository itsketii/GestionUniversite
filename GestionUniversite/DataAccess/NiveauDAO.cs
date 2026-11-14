using System.Data;
using GestionUniversite.Models;

namespace GestionUniversite.DataAccess;

public class NiveauDAO
{
    public DataTable Lister() => Sql.Table("SELECT idNiveau, codeNiveau, libelle FROM Niveau ORDER BY codeNiveau");

    public Niveau Obtenir(int id)
    {
        var dt = Sql.Table("SELECT * FROM Niveau WHERE idNiveau = @id", Sql.P("@id", id));
        if (dt.Rows.Count == 0) return null;
        var r = dt.Rows[0];
        return new Niveau
        {
            IdNiveau = Convert.ToInt32(r["idNiveau"]),
            CodeNiveau = (string)r["codeNiveau"],
            Libelle = (string)r["libelle"]
        };
    }

    public void Enregistrer(Niveau o)
    {
        if (o.IdNiveau == 0)
            Sql.Executer("INSERT INTO Niveau (codeNiveau, libelle) VALUES (@codeNiveau, @libelle);", Sql.P("@codeNiveau", o.CodeNiveau), Sql.P("@libelle", o.Libelle));
        else
            Sql.Executer("UPDATE Niveau SET codeNiveau = @codeNiveau, libelle = @libelle WHERE idNiveau = @id;", Sql.P("@codeNiveau", o.CodeNiveau), Sql.P("@libelle", o.Libelle), Sql.P("@id", o.IdNiveau));
    }

    public void Supprimer(int id) => Sql.Executer("DELETE FROM Niveau WHERE idNiveau = @id", Sql.P("@id", id));
}
