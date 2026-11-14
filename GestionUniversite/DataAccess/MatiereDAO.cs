using System.Data;
using GestionUniversite.Models;

namespace GestionUniversite.DataAccess;

public class MatiereDAO
{
    public DataTable Lister() => Sql.Table("SELECT idMatiere, codeMatiere, intitule, credits FROM Matiere ORDER BY intitule");

    public Matiere Obtenir(int id)
    {
        var dt = Sql.Table("SELECT * FROM Matiere WHERE idMatiere = @id", Sql.P("@id", id));
        if (dt.Rows.Count == 0) return null;
        var r = dt.Rows[0];
        return new Matiere
        {
            IdMatiere = Convert.ToInt32(r["idMatiere"]),
            CodeMatiere = (string)r["codeMatiere"],
            Intitule = (string)r["intitule"],
            Credits = Convert.ToInt32(r["credits"])
        };
    }

    public void Enregistrer(Matiere o)
    {
        if (o.IdMatiere == 0)
            Sql.Executer("INSERT INTO Matiere (codeMatiere, intitule, credits) VALUES (@codeMatiere, @intitule, @credits);", Sql.P("@codeMatiere", o.CodeMatiere), Sql.P("@intitule", o.Intitule), Sql.P("@credits", o.Credits));
        else
            Sql.Executer("UPDATE Matiere SET codeMatiere = @codeMatiere, intitule = @intitule, credits = @credits WHERE idMatiere = @id;", Sql.P("@codeMatiere", o.CodeMatiere), Sql.P("@intitule", o.Intitule), Sql.P("@credits", o.Credits), Sql.P("@id", o.IdMatiere));
    }

    public void Supprimer(int id) => Sql.Executer("DELETE FROM Matiere WHERE idMatiere = @id", Sql.P("@id", id));
}
