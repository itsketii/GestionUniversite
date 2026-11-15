using System.Data;
using GestionUniversite.Models;

namespace GestionUniversite.DataAccess;

public class EnseignantDAO
{
    public DataTable Lister() => Sql.Table("SELECT idEnseignant, matricule, nom, prenoms, email, telephone, grade, specialite FROM Enseignant ORDER BY nom, prenoms");

    public Enseignant Obtenir(int id)
    {
        var dt = Sql.Table("SELECT * FROM Enseignant WHERE idEnseignant = @id", Sql.P("@id", id));
        if (dt.Rows.Count == 0) return null;
        var r = dt.Rows[0];
        return new Enseignant
        {
            IdEnseignant = Convert.ToInt32(r["idEnseignant"]),
            Matricule = (string)r["matricule"],
            Nom = (string)r["nom"],
            Prenoms = (string)r["prenoms"],
            Email = (string)r["email"],
            Telephone = r["telephone"] as string,
            Grade = r["grade"] as string,
            Specialite = r["specialite"] as string
        };
    }

    public void Enregistrer(Enseignant o)
    {
        if (o.IdEnseignant == 0)
            Sql.Executer("INSERT INTO Enseignant (matricule, nom, prenoms, email, telephone, grade, specialite) VALUES (@matricule, @nom, @prenoms, @email, @telephone, @grade, @specialite);", Sql.P("@matricule", o.Matricule), Sql.P("@nom", o.Nom), Sql.P("@prenoms", o.Prenoms), Sql.P("@email", o.Email), Sql.P("@telephone", o.Telephone), Sql.P("@grade", o.Grade), Sql.P("@specialite", o.Specialite));
        else
            Sql.Executer("UPDATE Enseignant SET matricule = @matricule, nom = @nom, prenoms = @prenoms, email = @email, telephone = @telephone, grade = @grade, specialite = @specialite WHERE idEnseignant = @id;", Sql.P("@matricule", o.Matricule), Sql.P("@nom", o.Nom), Sql.P("@prenoms", o.Prenoms), Sql.P("@email", o.Email), Sql.P("@telephone", o.Telephone), Sql.P("@grade", o.Grade), Sql.P("@specialite", o.Specialite), Sql.P("@id", o.IdEnseignant));
    }

    public void Supprimer(int id) => Sql.Executer("DELETE FROM Enseignant WHERE idEnseignant = @id", Sql.P("@id", id));
}
