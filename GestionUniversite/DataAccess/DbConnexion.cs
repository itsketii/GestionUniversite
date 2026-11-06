using Microsoft.Data.SqlClient;

namespace GestionUniversite.DataAccess;

public static class DbConnexion
{
    // A ADAPTER : nom de ton serveur SQL Server
    // Exemples : "."  |  "localhost\SQLEXPRESS"  |  "(localdb)\MSSQLLocalDB"
    private const string Serveur = @"KETY\SQLEXPRESS";
    private const string Base = "dbGestionUniversite";

    public static string ChaineConnexion =>
        $"Server={Serveur};Database={Base};Trusted_Connection=True;TrustServerCertificate=True;";

    public static SqlConnection Creer() => new SqlConnection(ChaineConnexion);

    public static bool Tester(out string message)
    {
        try
        {
            using var cn = Creer();
            cn.Open();
            message = $"Connecté à {cn.DataSource} / {cn.Database}";
            return true;
        }
        catch (Exception ex)
        {
            message = "Connexion impossible : " + ex.Message;
            return false;
        }
    }
}
