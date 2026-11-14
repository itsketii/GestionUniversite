using System.Data;
using Microsoft.Data.SqlClient;
using GestionUniversite.Models;

namespace GestionUniversite.DataAccess;

public class UtilisateurDAO
{
    // Retourne l'utilisateur si les identifiants sont corrects, sinon null
    public Utilisateur Authentifier(string email, string motDePasse)
    {
        using var cn = DbConnexion.Creer();
        using var cmd = new SqlCommand("SP_Utilisateur_Login", cn) { CommandType = CommandType.StoredProcedure };
        cmd.Parameters.AddWithValue("@email", email);
        cmd.Parameters.AddWithValue("@motDePasse", motDePasse);
        cn.Open();
        using var rd = cmd.ExecuteReader();
        if (!rd.Read()) return null;
        return new Utilisateur
        {
            IdUtilisateur = (int)rd["idUtilisateur"],
            NomComplet = (string)rd["nomComplet"],
            Email = (string)rd["email"],
            Role = (string)rd["role"]
        };
    }

    public DataTable Lister() => Sql.Table(
        "SELECT idUtilisateur, nomComplet, email, role, CASE WHEN actif = 1 THEN N'Oui' ELSE N'Non' END AS actif " +
        "FROM Utilisateur ORDER BY nomComplet");

    public Utilisateur Obtenir(int id)
    {
        var dt = Sql.Table("SELECT idUtilisateur, nomComplet, email, role, actif FROM Utilisateur WHERE idUtilisateur = @id", Sql.P("@id", id));
        if (dt.Rows.Count == 0) return null;
        var r = dt.Rows[0];
        return new Utilisateur
        {
            IdUtilisateur = Convert.ToInt32(r["idUtilisateur"]),
            NomComplet = (string)r["nomComplet"],
            Email = (string)r["email"],
            Role = (string)r["role"],
            Actif = (bool)r["actif"]
        };
    }

    // Le mot de passe n'est enregistré que s'il est renseigné (obligatoire à la création)
    public void Enregistrer(Utilisateur u, string motDePasse)
    {
        if (u.IdUtilisateur == 0)
        {
            Sql.Executer("INSERT INTO Utilisateur (nomComplet, email, motDePasseHash, role, actif) " +
                         "VALUES (@nom, @email, HASHBYTES('SHA2_256', @mdp), @role, @actif)",
                Sql.P("@nom", u.NomComplet), Sql.P("@email", u.Email), Sql.P("@mdp", motDePasse),
                Sql.P("@role", u.Role), Sql.P("@actif", u.Actif));
            return;
        }

        Sql.Executer("UPDATE Utilisateur SET nomComplet = @nom, email = @email, role = @role, actif = @actif WHERE idUtilisateur = @id",
            Sql.P("@nom", u.NomComplet), Sql.P("@email", u.Email), Sql.P("@role", u.Role),
            Sql.P("@actif", u.Actif), Sql.P("@id", u.IdUtilisateur));
        if (!string.IsNullOrEmpty(motDePasse))
            Sql.Executer("UPDATE Utilisateur SET motDePasseHash = HASHBYTES('SHA2_256', @mdp) WHERE idUtilisateur = @id",
                Sql.P("@mdp", motDePasse), Sql.P("@id", u.IdUtilisateur));
    }

    public void Supprimer(int id) => Sql.Executer("DELETE FROM Utilisateur WHERE idUtilisateur = @id", Sql.P("@id", id));

    public bool ChangerMotDePasse(int id, string ancien, string nouveau) =>
        Sql.Executer("UPDATE Utilisateur SET motDePasseHash = HASHBYTES('SHA2_256', @nouveau) " +
                     "WHERE idUtilisateur = @id AND motDePasseHash = HASHBYTES('SHA2_256', @ancien)",
            Sql.P("@nouveau", nouveau), Sql.P("@id", id), Sql.P("@ancien", ancien)) > 0;
}
