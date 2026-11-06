using System.Data;
using Microsoft.Data.SqlClient;
using GestionUniversite.Models;

namespace GestionUniversite.DataAccess;

public class EtudiantDAO
{
    public List<Etudiant> GetAll()
    {
        var liste = new List<Etudiant>();
        using var cn = DbConnexion.Creer();
        using var cmd = new SqlCommand("SP_Etudiant_ReadAll", cn) { CommandType = CommandType.StoredProcedure };
        cn.Open();
        using var rd = cmd.ExecuteReader();
        while (rd.Read()) liste.Add(Mapper(rd));
        return liste;
    }

    public Etudiant GetById(int id)
    {
        using var cn = DbConnexion.Creer();
        using var cmd = new SqlCommand("SP_Etudiant_ReadById", cn) { CommandType = CommandType.StoredProcedure };
        cmd.Parameters.AddWithValue("@idEtudiant", id);
        cn.Open();
        using var rd = cmd.ExecuteReader();
        return rd.Read() ? Mapper(rd) : null;
    }

    public void Create(Etudiant e)
    {
        using var cn = DbConnexion.Creer();
        using var cmd = new SqlCommand("SP_Etudiant_Create", cn) { CommandType = CommandType.StoredProcedure };
        AjouterParametres(cmd, e);
        cn.Open();
        e.IdEtudiant = (int)cmd.ExecuteScalar();
    }

    public void Update(Etudiant e)
    {
        using var cn = DbConnexion.Creer();
        using var cmd = new SqlCommand("SP_Etudiant_Update", cn) { CommandType = CommandType.StoredProcedure };
        cmd.Parameters.AddWithValue("@idEtudiant", e.IdEtudiant);
        AjouterParametres(cmd, e);
        cn.Open();
        cmd.ExecuteNonQuery();
    }

    public void Delete(int id)
    {
        using var cn = DbConnexion.Creer();
        using var cmd = new SqlCommand("SP_Etudiant_Delete", cn) { CommandType = CommandType.StoredProcedure };
        cmd.Parameters.AddWithValue("@idEtudiant", id);
        cn.Open();
        cmd.ExecuteNonQuery();
    }

    private static void AjouterParametres(SqlCommand cmd, Etudiant e)
    {
        cmd.Parameters.AddWithValue("@matricule", e.Matricule);
        cmd.Parameters.AddWithValue("@nom", e.Nom);
        cmd.Parameters.AddWithValue("@prenoms", e.Prenoms);
        cmd.Parameters.AddWithValue("@dateNaissance", e.DateNaissance);
        cmd.Parameters.AddWithValue("@lieuNaissance", (object)e.LieuNaissance ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@sexe", e.Sexe);
        cmd.Parameters.AddWithValue("@email", e.Email);
        cmd.Parameters.AddWithValue("@telephone", (object)e.Telephone ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@adresse", (object)e.Adresse ?? DBNull.Value);
    }

    private static string Texte(SqlDataReader rd, string colonne)
        => rd[colonne] == DBNull.Value ? null : (string)rd[colonne];

    private static Etudiant Mapper(SqlDataReader rd) => new Etudiant
    {
        IdEtudiant = (int)rd["idEtudiant"],
        Matricule = (string)rd["matricule"],
        Nom = (string)rd["nom"],
        Prenoms = (string)rd["prenoms"],
        DateNaissance = (DateTime)rd["dateNaissance"],
        LieuNaissance = Texte(rd, "lieuNaissance"),
        Sexe = rd["sexe"].ToString(),
        Email = (string)rd["email"],
        Telephone = Texte(rd, "telephone"),
        Adresse = Texte(rd, "adresse")
    };
}
