using System.Data;

namespace GestionUniversite.DataAccess;

// Listes pour alimenter les listes déroulantes
public static class ReferentielDAO
{
    private const string AnneeActiveSql = "(SELECT idAnnee FROM AnneeAcademique WHERE estActive = 1)";

    public static DataTable Etudiants() => Sql.Table(
        "SELECT idEtudiant, matricule + N' - ' + nom + N' ' + prenoms AS libelle FROM Etudiant ORDER BY nom, prenoms");

    public static DataTable ClassesActives() => Sql.Table(
        $"SELECT idClasse, libelle FROM Classe WHERE idAnnee = {AnneeActiveSql} ORDER BY libelle");

    public static DataTable Filieres() => Sql.Table("SELECT idFiliere, codeFiliere, libelle FROM Filiere ORDER BY libelle");

    public static DataTable Niveaux() => Sql.Table("SELECT idNiveau, codeNiveau, libelle FROM Niveau ORDER BY codeNiveau");

    public static DataTable Annees() => Sql.Table("SELECT idAnnee, libelle, estActive FROM AnneeAcademique ORDER BY libelle DESC");

    public static DataTable Matieres() => Sql.Table(
        "SELECT idMatiere, codeMatiere + N' - ' + intitule AS libelle FROM Matiere ORDER BY intitule");

    public static DataTable Enseignants() => Sql.Table(
        "SELECT idEnseignant, nom + N' ' + prenoms AS libelle FROM Enseignant ORDER BY nom, prenoms");

    public static DataTable Salles() => Sql.Table(
        "SELECT idSalle, codeSalle + N' (' + typeSalle + N', ' + CAST(capacite AS NVARCHAR(10)) + N' places)' AS libelle " +
        "FROM Salle ORDER BY codeSalle");

    public static DataTable CoursParClasse(int idClasse) => Sql.Table(
        "SELECT idCours, matiere + N' - ' + enseignant AS libelle FROM vCoursListe WHERE idClasse = @idClasse ORDER BY matiere",
        Sql.P("@idClasse", idClasse));


    public static string AnneeActive()
    {
        var dt = Sql.Table("SELECT libelle FROM AnneeAcademique WHERE estActive = 1");
        return dt.Rows.Count == 0 ? "Aucune année active" : Convert.ToString(dt.Rows[0][0]);
    }
}
