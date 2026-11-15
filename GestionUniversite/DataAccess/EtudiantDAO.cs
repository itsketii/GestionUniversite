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

    // Liste pour l'écran (classe et statut de l'année active)
    public DataTable GetListe()
    {
        var dt = new DataTable();
        using var cn = DbConnexion.Creer();
        using var da = new SqlDataAdapter(
            "SELECT idEtudiant, matricule, nom, prenoms, email, classe, statutInscription " +
            "FROM vEtudiantsListe ORDER BY nom, prenoms", cn);
        da.Fill(dt);
        return dt;
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

    // Matricules et e-mails déjà présents (détection des doublons à l'import)
    public (HashSet<string> Matricules, HashSet<string> Emails) Existants()
    {
        var matricules = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        var emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        foreach (DataRow ligne in Sql.Table("SELECT matricule, email FROM Etudiant").Rows)
        {
            matricules.Add(Convert.ToString(ligne["matricule"]));
            emails.Add(Convert.ToString(ligne["email"]));
        }
        return (matricules, emails);
    }

    // Import en une seule transaction : tout est enregistré, ou rien
    public int Importer(List<Etudiant> etudiants, int? idClasse, decimal frais, bool valider)
    {
        using var cn = DbConnexion.Creer();
        cn.Open();
        using var tx = cn.BeginTransaction();
        try
        {
            foreach (var etudiant in etudiants)
            {
                int idEtudiant;
                using (var cmd = new SqlCommand("SP_Etudiant_Create", cn, tx) { CommandType = CommandType.StoredProcedure })
                {
                    AjouterParametres(cmd, etudiant);
                    idEtudiant = (int)cmd.ExecuteScalar();
                }
                if (idClasse == null) continue;

                int idInscription;
                using (var cmd = new SqlCommand("sp_InscrireEtudiant", cn, tx) { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.AddWithValue("@idEtudiant", idEtudiant);
                    cmd.Parameters.AddWithValue("@idClasse", idClasse.Value);
                    cmd.Parameters.AddWithValue("@fraisInscription", frais);
                    idInscription = Convert.ToInt32(cmd.ExecuteScalar());
                }
                if (valider)
                {
                    using var cmd = new SqlCommand("sp_ValiderInscription", cn, tx) { CommandType = CommandType.StoredProcedure };
                    cmd.Parameters.AddWithValue("@idInscription", idInscription);
                    cmd.ExecuteNonQuery();
                }
            }
            tx.Commit();
            return etudiants.Count;
        }
        catch
        {
            try { tx.Rollback(); } catch { }
            throw;
        }
    }
}
