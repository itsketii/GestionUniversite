USE dbGestionUniversite;
GO

-- Utilisateurs de l'application (connexion)
IF OBJECT_ID(N'Utilisateur', N'U') IS NULL
CREATE TABLE Utilisateur (
    idUtilisateur  INT IDENTITY(1,1) CONSTRAINT PK_Utilisateur PRIMARY KEY,
    nomComplet     NVARCHAR(100) NOT NULL,
    email          NVARCHAR(100) NOT NULL CONSTRAINT UQ_Utilisateur_email UNIQUE,
    motDePasseHash VARBINARY(32) NOT NULL,
    role           NVARCHAR(20)  NOT NULL CONSTRAINT DF_Utilisateur_role DEFAULT N'Administrateur'
                   CONSTRAINT CK_Utilisateur_role CHECK (role IN (N'Administrateur', N'Scolarité', N'Enseignant')),
    actif          BIT NOT NULL CONSTRAINT DF_Utilisateur_actif DEFAULT 1
);
GO

-- Compte de départ : admin@iit.ci / Admin@2026  (à changer ensuite)
IF NOT EXISTS (SELECT 1 FROM Utilisateur WHERE email = N'admin@iit.ci')
    INSERT INTO Utilisateur (nomComplet, email, motDePasseHash, role)
    VALUES (N'Administration IIT', N'admin@iit.ci', HASHBYTES('SHA2_256', N'Admin@2026'), N'Administrateur');
GO

CREATE OR ALTER PROCEDURE SP_Utilisateur_Login
    @email NVARCHAR(100), @motDePasse NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT idUtilisateur, nomComplet, email, role
    FROM Utilisateur
    WHERE email = @email AND actif = 1
      AND motDePasseHash = HASHBYTES('SHA2_256', @motDePasse);
END
GO

-- Liste des étudiants avec classe et statut d'inscription de l'année active
CREATE OR ALTER VIEW vEtudiantsListe AS
SELECT e.idEtudiant, e.matricule, e.nom, e.prenoms, e.email,
       cl.libelle AS classe,
       ins.statut AS statutInscription
FROM Etudiant e
LEFT JOIN Inscription ins ON ins.idEtudiant = e.idEtudiant
                         AND ins.idAnnee = (SELECT idAnnee FROM AnneeAcademique WHERE estActive = 1)
LEFT JOIN Classe cl ON cl.idClasse = ins.idClasse;
GO
