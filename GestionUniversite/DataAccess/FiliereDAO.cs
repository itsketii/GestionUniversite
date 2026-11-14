using System.Data;
using GestionUniversite.Models;

namespace GestionUniversite.DataAccess;

public class FiliereDAO
{
    public DataTable Lister() => Sql.Table("SELECT idFiliere, codeFiliere, libelle FROM Filiere ORDER BY libelle");

    public Filiere Obtenir(int id)
    {
        var dt = Sql.Table("SELECT * FROM Filiere WHERE idFiliere = @id", Sql.P("@id", id));
        if (dt.Rows.Count == 0) return null;
        var r = dt.Rows[0];
        return new Filiere
        {
            IdFiliere = Convert.ToInt32(r["idFiliere"]),
            CodeFiliere = (string)r["codeFiliere"],
            Libelle = (string)r["libelle"]
        };
    }

    public void Enregistrer(Filiere o)
    {
        if (o.IdFiliere == 0)
            Sql.Executer("INSERT INTO Filiere (codeFiliere, libelle) VALUES (@codeFiliere, @libelle);", Sql.P("@codeFiliere", o.CodeFiliere), Sql.P("@libelle", o.Libelle));
        else
            Sql.Executer("UPDATE Filiere SET codeFiliere = @codeFiliere, libelle = @libelle WHERE idFiliere = @id;", Sql.P("@codeFiliere", o.CodeFiliere), Sql.P("@libelle", o.Libelle), Sql.P("@id", o.IdFiliere));
    }

    public void Supprimer(int id) => Sql.Executer("DELETE FROM Filiere WHERE idFiliere = @id", Sql.P("@id", id));
}
