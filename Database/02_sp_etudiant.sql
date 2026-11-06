USE dbGestionUniversite;
GO

CREATE OR ALTER PROCEDURE SP_Etudiant_Create
    @matricule NVARCHAR(20), @nom NVARCHAR(50), @prenoms NVARCHAR(100), @dateNaissance DATE,
    @lieuNaissance NVARCHAR(100) = NULL, @sexe CHAR(1), @email NVARCHAR(100),
    @telephone NVARCHAR(20) = NULL, @adresse NVARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Etudiant (matricule, nom, prenoms, dateNaissance, lieuNaissance, sexe, email, telephone, adresse)
    VALUES (@matricule, @nom, @prenoms, @dateNaissance, @lieuNaissance, @sexe, @email, @telephone, @adresse);
    SELECT CAST(SCOPE_IDENTITY() AS INT) AS idEtudiant;
END
GO

CREATE OR ALTER PROCEDURE SP_Etudiant_ReadAll
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Etudiant ORDER BY nom, prenoms;
END
GO

CREATE OR ALTER PROCEDURE SP_Etudiant_ReadById @idEtudiant INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM Etudiant WHERE idEtudiant = @idEtudiant;
END
GO

CREATE OR ALTER PROCEDURE SP_Etudiant_Update
    @idEtudiant INT, @matricule NVARCHAR(20), @nom NVARCHAR(50), @prenoms NVARCHAR(100), @dateNaissance DATE,
    @lieuNaissance NVARCHAR(100) = NULL, @sexe CHAR(1), @email NVARCHAR(100),
    @telephone NVARCHAR(20) = NULL, @adresse NVARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Etudiant
    SET matricule = @matricule, nom = @nom, prenoms = @prenoms, dateNaissance = @dateNaissance,
        lieuNaissance = @lieuNaissance, sexe = @sexe, email = @email, telephone = @telephone, adresse = @adresse
    WHERE idEtudiant = @idEtudiant;
END
GO

CREATE OR ALTER PROCEDURE SP_Etudiant_Delete @idEtudiant INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Etudiant WHERE idEtudiant = @idEtudiant;
END
GO
