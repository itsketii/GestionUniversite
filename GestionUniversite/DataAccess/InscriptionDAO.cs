using System.Data;
using Microsoft.Data.SqlClient;

namespace GestionUniversite.DataAccess;

public class InscriptionDAO
{
    public DataTable GetListe() => Sql.Table(
        "SELECT idInscription, CONVERT(VARCHAR(10), dateInscription, 103) AS jour, matricule, etudiant, classe, " +
        "FORMAT(fraisInscription, 'N0', 'fr-FR') + N' FCFA' AS frais, statut " +
        "FROM vInscriptionsListe WHERE idAnnee = (SELECT idAnnee FROM AnneeAcademique WHERE estActive = 1) " +
        "ORDER BY dateInscription DESC, etudiant");

    public void Inscrire(int idEtudiant, int idClasse, decimal frais, bool valider)
    {
        int id;
        using (var cn = DbConnexion.Creer())
        using (var cmd = new SqlCommand("sp_InscrireEtudiant", cn) { CommandType = CommandType.StoredProcedure })
        {
            cmd.Parameters.AddWithValue("@idEtudiant", idEtudiant);
            cmd.Parameters.AddWithValue("@idClasse", idClasse);
            cmd.Parameters.AddWithValue("@fraisInscription", frais);
            cn.Open();
            id = Convert.ToInt32(cmd.ExecuteScalar());
        }
        if (valider) Valider(id);
    }

    public void Valider(int idInscription) => Sql.Proc("sp_ValiderInscription", Sql.P("@idInscription", idInscription));

    public void Annuler(int idInscription) => Sql.Proc("sp_AnnulerInscription", Sql.P("@idInscription", idInscription));


    // Données du reçu d'inscription
    public DataRow GetRecu(int idInscription)
    {
        var dt = Sql.Table(
            "SELECT v.idInscription, v.dateInscription, v.matricule, v.etudiant, v.classe, v.fraisInscription, v.statut, a.libelle AS annee " +
            "FROM vInscriptionsListe v JOIN AnneeAcademique a ON a.idAnnee = v.idAnnee WHERE v.idInscription = @id",
            Sql.P("@id", idInscription));
        return dt.Rows.Count == 0 ? null : dt.Rows[0];
    }
}
