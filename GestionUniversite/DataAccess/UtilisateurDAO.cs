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
}
