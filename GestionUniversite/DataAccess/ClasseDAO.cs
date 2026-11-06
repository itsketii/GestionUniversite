using System.Data;

namespace GestionUniversite.DataAccess;

public class ClasseDAO
{
    public DataTable ListerClasses() => Sql.Table(
        "SELECT idClasse, libelle, filiere, niveau, annee, effectif FROM vClassesListe ORDER BY annee DESC, libelle");

    public DataTable ListerCours(int idClasse) => Sql.Table(
        "SELECT idCours, matiere, enseignant, volumeHoraire FROM vCoursListe WHERE idClasse = @idClasse ORDER BY matiere",
        Sql.P("@idClasse", idClasse));

    public void Creer(string libelle, int idFiliere, int idNiveau, int idAnnee) => Sql.Proc("SP_Classe_Create",
        Sql.P("@libelle", libelle), Sql.P("@idFiliere", idFiliere), Sql.P("@idNiveau", idNiveau), Sql.P("@idAnnee", idAnnee));

    public void Supprimer(int idClasse) => Sql.Proc("SP_Classe_Delete", Sql.P("@idClasse", idClasse));

    public void AjouterCours(int idClasse, int idMatiere, int idEnseignant, int volumeHoraire) => Sql.Proc("SP_Cours_Create",
        Sql.P("@idClasse", idClasse), Sql.P("@idMatiere", idMatiere), Sql.P("@idEnseignant", idEnseignant),
        Sql.P("@volumeHoraire", volumeHoraire));

    public void RetirerCours(int idCours) => Sql.Proc("SP_Cours_Delete", Sql.P("@idCours", idCours));
}
