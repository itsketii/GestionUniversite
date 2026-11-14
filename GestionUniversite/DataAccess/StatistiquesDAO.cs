using System.Data;

namespace GestionUniversite.DataAccess;

// Lectures pour le tableau de bord et la page Statistiques (toutes sur l'année académique active)
public class StatistiquesDAO
{
    private const string Annee = "(SELECT idAnnee FROM AnneeAcademique WHERE estActive = 1)";

    public int EtudiantsInscrits() =>
        Entier($"SELECT COUNT(*) FROM Inscription WHERE statut = N'Validée' AND idAnnee = {Annee}");

    public int InscriptionsEnAttente() =>
        Entier($"SELECT COUNT(*) FROM Inscription WHERE statut = N'En attente' AND idAnnee = {Annee}");

    public int ClassesOuvertes() =>
        Entier($"SELECT COUNT(*) FROM Classe WHERE idAnnee = {Annee}");

    public int SeancesSemaine() =>
        Entier("SELECT COUNT(*) FROM Seance WHERE statut <> N'Annulée' " +
               "AND dateSeance BETWEEN CAST(GETDATE() AS DATE) AND DATEADD(day, 7, CAST(GETDATE() AS DATE))");

    public int SeancesPlanifiees() =>
        Entier("SELECT COUNT(*) FROM Seance WHERE statut <> N'Annulée'");

    public int AbsencesNonJustifiees() =>
        Entier("SELECT COUNT(*) FROM Absence WHERE justifiee = 0");

    public decimal FraisEncaisses() =>
        Convert.ToDecimal(Sql.Valeur($"SELECT ISNULL(SUM(fraisInscription), 0) FROM Inscription WHERE statut = N'Validée' AND idAnnee = {Annee}"));

    public int TauxValidation() =>
        Entier($"SELECT CASE WHEN COUNT(*) = 0 THEN 0 ELSE 100 * SUM(CASE WHEN statut = N'Validée' THEN 1 ELSE 0 END) / COUNT(*) END " +
               $"FROM Inscription WHERE statut <> N'Annulée' AND idAnnee = {Annee}");

    public DataTable ProchainesSeances() => Sql.Table(
        "SELECT TOP 8 CONVERT(VARCHAR(5), dateSeance, 103) AS jour, " +
        "CONVERT(VARCHAR(5), heureDebut, 108) + ' - ' + CONVERT(VARCHAR(5), heureFin, 108) AS heure, " +
        "matiere, classe, salle, typeSeance " +
        "FROM vEmploiDuTemps WHERE statut <> N'Annulée' AND dateSeance >= CAST(GETDATE() AS DATE) " +
        "ORDER BY dateSeance, heureDebut");

    public DataTable DernieresInscriptions() => Sql.Table(
        "SELECT TOP 8 CONVERT(VARCHAR(10), dateInscription, 103) AS jour, etudiant, classe, statut " +
        $"FROM vInscriptionsListe WHERE idAnnee = {Annee} ORDER BY dateInscription DESC, idInscription DESC");

    public DataTable InscriptionsParFiliere() => Sql.Table(
        "SELECT f.libelle AS libelle, COUNT(*) AS valeur FROM Inscription i " +
        "JOIN Classe c ON c.idClasse = i.idClasse JOIN Filiere f ON f.idFiliere = c.idFiliere " +
        $"WHERE i.statut = N'Validée' AND i.idAnnee = {Annee} GROUP BY f.libelle ORDER BY valeur DESC");

    public DataTable InscriptionsParNiveau() => Sql.Table(
        "SELECT n.libelle AS libelle, COUNT(*) AS valeur FROM Inscription i " +
        "JOIN Classe c ON c.idClasse = i.idClasse JOIN Niveau n ON n.idNiveau = c.idNiveau " +
        $"WHERE i.statut = N'Validée' AND i.idAnnee = {Annee} GROUP BY n.libelle, n.codeNiveau ORDER BY n.codeNiveau");

    public DataTable StatutsInscription() => Sql.Table(
        $"SELECT statut AS libelle, COUNT(*) AS valeur FROM Inscription WHERE idAnnee = {Annee} GROUP BY statut ORDER BY valeur DESC");

    public DataTable RepartitionSexe() => Sql.Table(
        "SELECT CASE e.sexe WHEN 'F' THEN N'Femmes' ELSE N'Hommes' END AS libelle, COUNT(*) AS valeur FROM Inscription i " +
        $"JOIN Etudiant e ON e.idEtudiant = i.idEtudiant WHERE i.statut = N'Validée' AND i.idAnnee = {Annee} GROUP BY e.sexe");

    public DataTable EffectifParClasse() => Sql.Table(
        "SELECT libelle, effectif AS valeur FROM vEffectifClasse " +
        $"WHERE anneeAcademique = (SELECT libelle FROM AnneeAcademique WHERE estActive = 1) ORDER BY libelle");

    public DataTable AbsencesParMatiere() => Sql.Table(
        "SELECT TOP 8 m.intitule AS libelle, COUNT(*) AS valeur FROM Absence a " +
        "JOIN Seance s ON s.idSeance = a.idSeance JOIN Cours c ON c.idCours = s.idCours JOIN Matiere m ON m.idMatiere = c.idMatiere " +
        "GROUP BY m.intitule ORDER BY valeur DESC");

    private static int Entier(string sql) => Convert.ToInt32(Sql.Valeur(sql));
}
