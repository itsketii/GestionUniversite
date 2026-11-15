USE dbGestionUniversite;
GO

CREATE OR ALTER VIEW vInscriptionsListe AS
SELECT i.idInscription, i.idAnnee, i.dateInscription, e.matricule,
       e.nom + N' ' + e.prenoms AS etudiant,
       cl.libelle AS classe, i.fraisInscription, i.statut
FROM Inscription i
JOIN Etudiant e ON e.idEtudiant = i.idEtudiant
JOIN Classe cl  ON cl.idClasse  = i.idClasse;
GO

CREATE OR ALTER VIEW vClassesListe AS
SELECT cl.idClasse, cl.libelle, f.codeFiliere AS filiere, n.codeNiveau AS niveau, a.libelle AS annee,
       (SELECT COUNT(*) FROM Inscription i WHERE i.idClasse = cl.idClasse AND i.statut = N'Validée') AS effectif
FROM Classe cl
JOIN Filiere f ON f.idFiliere = cl.idFiliere
JOIN Niveau n  ON n.idNiveau  = cl.idNiveau
JOIN AnneeAcademique a ON a.idAnnee = cl.idAnnee;
GO

CREATE OR ALTER VIEW vCoursListe AS
SELECT c.idCours, c.idClasse, m.intitule AS matiere,
       e.nom + N' ' + e.prenoms AS enseignant, c.volumeHoraire
FROM Cours c
JOIN Matiere m    ON m.idMatiere    = c.idMatiere
JOIN Enseignant e ON e.idEnseignant = c.idEnseignant;
GO

CREATE OR ALTER PROCEDURE SP_Classe_Create
    @libelle NVARCHAR(100), @idFiliere INT, @idNiveau INT, @idAnnee INT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Classe (libelle, idFiliere, idNiveau, idAnnee) VALUES (@libelle, @idFiliere, @idNiveau, @idAnnee);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS idClasse;
END
GO

CREATE OR ALTER PROCEDURE SP_Classe_Delete @idClasse INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Classe WHERE idClasse = @idClasse;
END
GO

CREATE OR ALTER PROCEDURE SP_Cours_Create
    @idClasse INT, @idMatiere INT, @idEnseignant INT, @volumeHoraire SMALLINT
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Cours (volumeHoraire, idClasse, idMatiere, idEnseignant)
    VALUES (@volumeHoraire, @idClasse, @idMatiere, @idEnseignant);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS idCours;
END
GO

CREATE OR ALTER PROCEDURE SP_Cours_Delete @idCours INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Cours WHERE idCours = @idCours;
END
GO

CREATE OR ALTER PROCEDURE SP_Absence_Supprimer @idSeance INT, @idEtudiant INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Absence WHERE idSeance = @idSeance AND idEtudiant = @idEtudiant;
END
GO
