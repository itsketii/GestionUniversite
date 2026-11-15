using System.Data;
using Microsoft.Data.SqlClient;

namespace GestionUniversite.DataAccess;

// Petits utilitaires partagés par les DAO
internal static class Sql
{
    public static SqlParameter P(string nom, object valeur) => new SqlParameter(nom, valeur ?? DBNull.Value);

    public static DataTable Table(string sql, params SqlParameter[] parametres)
    {
        var dt = new DataTable();
        using var cn = DbConnexion.Creer();
        using var cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddRange(parametres);
        using var da = new SqlDataAdapter(cmd);
        da.Fill(dt);
        return dt;
    }

    public static int Proc(string nom, params SqlParameter[] parametres)
    {
        using var cn = DbConnexion.Creer();
        using var cmd = new SqlCommand(nom, cn) { CommandType = CommandType.StoredProcedure };
        cmd.Parameters.AddRange(parametres);
        cn.Open();
        return cmd.ExecuteNonQuery();
    }

    // Requête SQL paramétrée (INSERT, UPDATE, DELETE)
    public static int Executer(string sql, params SqlParameter[] parametres)
    {
        using var cn = DbConnexion.Creer();
        using var cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddRange(parametres);
        cn.Open();
        return cmd.ExecuteNonQuery();
    }

    public static object Valeur(string sql, params SqlParameter[] parametres)
    {
        using var cn = DbConnexion.Creer();
        using var cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddRange(parametres);
        cn.Open();
        return cmd.ExecuteScalar();
    }
}
