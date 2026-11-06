/* ============================================================
   Projet 1 : Solution de gestion d'une université (SQL Server)
   Modules  : Inscriptions, Planification des cours,
              Absences (bonus)
   Contenu  : base, tables, contraintes, triggers, vues,
              procédures stockées, jeu d'essai
   ============================================================ */

USE master;
GO
IF DB_ID(N'dbGestionUniversite') IS NOT NULL
BEGIN
    ALTER DATABASE dbGestionUniversite SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE dbGestionUniversite;
END
GO
CREATE DATABASE dbGestionUniversite;
GO
USE dbGestionUniversite;
GO

/* ============================================================
   1. TABLES DE RÉFÉRENCE
   ============================================================ */

CREATE TABLE AnneeAcademique (
    idAnnee    INT IDENTITY(1,1) CONSTRAINT PK_AnneeAcademique PRIMARY KEY,
    libelle    NVARCHAR(20) NOT NULL CONSTRAINT UQ_Annee_libelle UNIQUE,
    dateDebut  DATE NOT NULL,
    dateFin    DATE NOT NULL,
    estActive  BIT NOT NULL CONSTRAINT DF_Annee_estActive DEFAULT 0,
    CONSTRAINT CK_Annee_dates CHECK (dateFin > dateDebut)
);
GO
-- Une seule année académique active à la fois
CREATE UNIQUE INDEX UX_Annee_active ON AnneeAcademique(estActive) WHERE estActive = 1;
GO

CREATE TABLE Filiere (
    idFiliere   INT IDENTITY(1,1) CONSTRAINT PK_Filiere PRIMARY KEY,
    codeFiliere NVARCHAR(10)  NOT NULL CONSTRAINT UQ_Filiere_code UNIQUE,
    libelle     NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Niveau (
    idNiveau   INT IDENTITY(1,1) CONSTRAINT PK_Niveau PRIMARY KEY,
    codeNiveau NVARCHAR(5)  NOT NULL CONSTRAINT UQ_Niveau_code UNIQUE,
    libelle    NVARCHAR(50) NOT NULL
);
GO

-- Une classe = une filière + un niveau + une année académique
CREATE TABLE Classe (
    idClasse  INT IDENTITY(1,1) CONSTRAINT PK_Classe PRIMARY KEY,
    libelle   NVARCHAR(100) NOT NULL,
    idFiliere INT NOT NULL CONSTRAINT FK_Classe_Filiere REFERENCES Filiere(idFiliere),
    idNiveau  INT NOT NULL CONSTRAINT FK_Classe_Niveau  REFERENCES Niveau(idNiveau),
    idAnnee   INT NOT NULL CONSTRAINT FK_Classe_Annee   REFERENCES AnneeAcademique(idAnnee),
    CONSTRAINT UQ_Classe_Promotion UNIQUE (idFiliere, idNiveau, idAnnee),
    -- sert de cible à la clé étrangère composée de Inscription
    CONSTRAINT UQ_Classe_ClasseAnnee UNIQUE (idClasse, idAnnee)
);
GO

CREATE TABLE Etudiant (
    idEtudiant    INT IDENTITY(1,1) CONSTRAINT PK_Etudiant PRIMARY KEY,
    matricule     NVARCHAR(20)  NOT NULL CONSTRAINT UQ_Etudiant_matricule UNIQUE,
    nom           NVARCHAR(50)  NOT NULL,
    prenoms       NVARCHAR(100) NOT NULL,
    dateNaissance DATE NOT NULL,
    lieuNaissance NVARCHAR(100) NULL,
    sexe          CHAR(1) NOT NULL CONSTRAINT CK_Etudiant_sexe CHECK (sexe IN ('M','F')),
    email         NVARCHAR(100) NOT NULL CONSTRAINT UQ_Etudiant_email UNIQUE,
    telephone     NVARCHAR(20)  NULL,
    adresse       NVARCHAR(200) NULL,
    CONSTRAINT CK_Etudiant_naissance CHECK (dateNaissance <= CAST(GETDATE() AS DATE))
);
GO

CREATE TABLE Enseignant (
    idEnseignant INT IDENTITY(1,1) CONSTRAINT PK_Enseignant PRIMARY KEY,
    matricule    NVARCHAR(20)  NOT NULL CONSTRAINT UQ_Enseignant_matricule UNIQUE,
    nom          NVARCHAR(50)  NOT NULL,
    prenoms      NVARCHAR(100) NOT NULL,
    email        NVARCHAR(100) NOT NULL CONSTRAINT UQ_Enseignant_email UNIQUE,
    telephone    NVARCHAR(20)  NULL,
    grade        NVARCHAR(50)  NULL,
    specialite   NVARCHAR(100) NULL
);
GO

CREATE TABLE Matiere (
    idMatiere   INT IDENTITY(1,1) CONSTRAINT PK_Matiere PRIMARY KEY,
    codeMatiere NVARCHAR(15)  NOT NULL CONSTRAINT UQ_Matiere_code UNIQUE,
    intitule    NVARCHAR(150) NOT NULL,
    credits     TINYINT NOT NULL CONSTRAINT CK_Matiere_credits CHECK (credits > 0)
);
GO

CREATE TABLE Salle (
    idSalle   INT IDENTITY(1,1) CONSTRAINT PK_Salle PRIMARY KEY,
    codeSalle NVARCHAR(15) NOT NULL CONSTRAINT UQ_Salle_code UNIQUE,
    capacite  SMALLINT NOT NULL CONSTRAINT CK_Salle_capacite CHECK (capacite > 0),
    typeSalle NVARCHAR(20) NOT NULL
        CONSTRAINT CK_Salle_type CHECK (typeSalle IN (N'Amphi', N'Salle de cours', N'Laboratoire', N'Salle informatique')),
    batiment  NVARCHAR(50) NULL
);
GO

/* ============================================================
   2. MODULE INSCRIPTIONS
   ============================================================ */

CREATE TABLE Inscription (
    idInscription    INT IDENTITY(1,1) CONSTRAINT PK_Inscription PRIMARY KEY,
    dateInscription  DATE NOT NULL CONSTRAINT DF_Inscription_date DEFAULT (CAST(GETDATE() AS DATE)),
    statut           NVARCHAR(15) NOT NULL CONSTRAINT DF_Inscription_statut DEFAULT N'En attente'
        CONSTRAINT CK_Inscription_statut CHECK (statut IN (N'En attente', N'Validée', N'Annulée')),
    fraisInscription DECIMAL(10,2) NOT NULL CONSTRAINT DF_Inscription_frais DEFAULT 0
        CONSTRAINT CK_Inscription_frais CHECK (fraisInscription >= 0),
    idEtudiant       INT NOT NULL CONSTRAINT FK_Inscription_Etudiant REFERENCES Etudiant(idEtudiant),
    idClasse         INT NOT NULL,
    idAnnee          INT NOT NULL,
    -- RG1 : un étudiant ne s'inscrit qu'une fois par année académique
    CONSTRAINT UQ_Inscription_EtudiantAnnee UNIQUE (idEtudiant, idAnnee),
    -- garantit que idAnnee est bien l'année de la classe choisie
    CONSTRAINT FK_Inscription_Classe FOREIGN KEY (idClasse, idAnnee)
        REFERENCES Classe(idClasse, idAnnee)
);
GO

/* ============================================================
   3. MODULE PLANIFICATION DES COURS
   ============================================================ */

-- Un cours = une matière enseignée à une classe par un enseignant
CREATE TABLE Cours (
    idCours       INT IDENTITY(1,1) CONSTRAINT PK_Cours PRIMARY KEY,
    volumeHoraire SMALLINT NOT NULL CONSTRAINT CK_Cours_volume CHECK (volumeHoraire > 0),
    idClasse      INT NOT NULL CONSTRAINT FK_Cours_Classe     REFERENCES Classe(idClasse),
    idMatiere     INT NOT NULL CONSTRAINT FK_Cours_Matiere    REFERENCES Matiere(idMatiere),
    idEnseignant  INT NOT NULL CONSTRAINT FK_Cours_Enseignant REFERENCES Enseignant(idEnseignant),
    CONSTRAINT UQ_Cours_ClasseMatiere UNIQUE (idClasse, idMatiere)
);
GO

-- Une séance = un créneau daté d'un cours, dans une salle
CREATE TABLE Seance (
    idSeance   INT IDENTITY(1,1) CONSTRAINT PK_Seance PRIMARY KEY,
    dateSeance DATE NOT NULL,
    heureDebut TIME(0) NOT NULL,
    heureFin   TIME(0) NOT NULL,
    typeSeance NVARCHAR(5) NOT NULL CONSTRAINT DF_Seance_type DEFAULT N'CM'
        CONSTRAINT CK_Seance_type CHECK (typeSeance IN (N'CM', N'TD', N'TP')),
    statut     NVARCHAR(15) NOT NULL CONSTRAINT DF_Seance_statut DEFAULT N'Planifiée'
        CONSTRAINT CK_Seance_statut CHECK (statut IN (N'Planifiée', N'Effectuée', N'Annulée')),
    idCours    INT NOT NULL CONSTRAINT FK_Seance_Cours REFERENCES Cours(idCours),
    idSalle    INT NOT NULL CONSTRAINT FK_Seance_Salle REFERENCES Salle(idSalle),
    CONSTRAINT CK_Seance_heures CHECK (heureFin > heureDebut)
);
GO
CREATE INDEX IX_Seance_date  ON Seance(dateSeance, idSalle);
CREATE INDEX IX_Seance_cours ON Seance(idCours);
GO

/* ============================================================
   4. BONUS : MODULE ABSENCES
   ============================================================ */

CREATE TABLE Absence (
    idAbsence  INT IDENTITY(1,1) CONSTRAINT PK_Absence PRIMARY KEY,
    justifiee  BIT NOT NULL CONSTRAINT DF_Absence_justifiee DEFAULT 0,
    motif      NVARCHAR(200) NULL,
    dateSaisie DATETIME2(0) NOT NULL CONSTRAINT DF_Absence_dateSaisie DEFAULT SYSDATETIME(),
    idSeance   INT NOT NULL CONSTRAINT FK_Absence_Seance   REFERENCES Seance(idSeance),
    idEtudiant INT NOT NULL CONSTRAINT FK_Absence_Etudiant REFERENCES Etudiant(idEtudiant),
    CONSTRAINT UQ_Absence_SeanceEtudiant UNIQUE (idSeance, idEtudiant)
);
GO

/* ============================================================
   5. TRIGGERS (règles de gestion non exprimables par CHECK/FK)
   ============================================================ */

-- Conflits de planification : salle, enseignant, classe + capacité de la salle
CREATE TRIGGER TR_Seance_Controles ON Seance
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- RG4 : une salle ne peut accueillir deux séances qui se chevauchent
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN Seance s ON s.idSeance <> i.idSeance
                     AND s.dateSeance = i.dateSeance
                     AND s.idSalle    = i.idSalle
                     AND s.heureDebut < i.heureFin
                     AND s.heureFin   > i.heureDebut
        WHERE i.statut <> N'Annulée' AND s.statut <> N'Annulée')
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50001, N'Conflit : la salle est déjà occupée sur ce créneau.', 1;
    END

    -- RG5 : un enseignant ne peut pas donner deux séances simultanées
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN Cours ci ON ci.idCours = i.idCours
        JOIN Seance s ON s.idSeance <> i.idSeance
                     AND s.dateSeance = i.dateSeance
                     AND s.heureDebut < i.heureFin
                     AND s.heureFin   > i.heureDebut
        JOIN Cours cs ON cs.idCours = s.idCours
        WHERE i.statut <> N'Annulée' AND s.statut <> N'Annulée'
          AND cs.idEnseignant = ci.idEnseignant)
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50002, N'Conflit : l''enseignant a déjà une séance sur ce créneau.', 1;
    END

    -- RG6 : une classe ne peut pas avoir deux séances simultanées
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN Cours ci ON ci.idCours = i.idCours
        JOIN Seance s ON s.idSeance <> i.idSeance
                     AND s.dateSeance = i.dateSeance
                     AND s.heureDebut < i.heureFin
                     AND s.heureFin   > i.heureDebut
        JOIN Cours cs ON cs.idCours = s.idCours
        WHERE i.statut <> N'Annulée' AND s.statut <> N'Annulée'
          AND cs.idClasse = ci.idClasse)
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50003, N'Conflit : la classe a déjà une séance sur ce créneau.', 1;
    END

    -- RG7 : la capacité de la salle doit couvrir l'effectif validé de la classe
    IF EXISTS (
        SELECT 1
        FROM inserted i
        JOIN Salle sa ON sa.idSalle = i.idSalle
        JOIN Cours c  ON c.idCours  = i.idCours
        WHERE i.statut <> N'Annulée'
          AND (SELECT COUNT(*) FROM Inscription ins
               WHERE ins.idClasse = c.idClasse AND ins.statut = N'Validée') > sa.capacite)
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50004, N'Capacité insuffisante : la salle est trop petite pour cette classe.', 1;
    END
END
GO

-- RG9 : une absence ne peut concerner qu'un étudiant inscrit (validé) dans la classe de la séance
CREATE TRIGGER TR_Absence_EtudiantDansClasse ON Absence
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (
        SELECT 1
        FROM inserted a
        JOIN Seance s ON s.idSeance = a.idSeance
        JOIN Cours c  ON c.idCours  = s.idCours
        WHERE NOT EXISTS (
            SELECT 1 FROM Inscription ins
            WHERE ins.idEtudiant = a.idEtudiant
              AND ins.idClasse   = c.idClasse
              AND ins.statut     = N'Validée'))
    BEGIN
        ROLLBACK TRANSACTION;
        THROW 50005, N'Cet étudiant n''est pas inscrit dans la classe de cette séance.', 1;
    END
END
GO

/* ============================================================
   6. VUES
   ============================================================ */

CREATE VIEW vEffectifClasse AS
SELECT cl.idClasse,
       cl.libelle,
       an.libelle AS anneeAcademique,
       COUNT(i.idInscription) AS effectif
FROM Classe cl
JOIN AnneeAcademique an ON an.idAnnee = cl.idAnnee
LEFT JOIN Inscription i ON i.idClasse = cl.idClasse AND i.statut = N'Validée'
GROUP BY cl.idClasse, cl.libelle, an.libelle;
GO

CREATE VIEW vEmploiDuTemps AS
SELECT s.idSeance,
       s.dateSeance,
       s.heureDebut,
       s.heureFin,
       s.typeSeance,
       s.statut,
       cl.libelle  AS classe,
       m.intitule  AS matiere,
       e.nom + N' ' + e.prenoms AS enseignant,
       sa.codeSalle AS salle
FROM Seance s
JOIN Cours c       ON c.idCours      = s.idCours
JOIN Classe cl     ON cl.idClasse    = c.idClasse
JOIN Matiere m     ON m.idMatiere    = c.idMatiere
JOIN Enseignant e  ON e.idEnseignant = c.idEnseignant
JOIN Salle sa      ON sa.idSalle     = s.idSalle;
GO

CREATE VIEW vAbsencesParEtudiant AS
SELECT et.idEtudiant,
       et.matricule,
       et.nom,
       et.prenoms,
       m.intitule AS matiere,
       COUNT(*)   AS nbAbsences,
       SUM(CASE WHEN a.justifiee = 1 THEN 1 ELSE 0 END) AS nbJustifiees
FROM Absence a
JOIN Etudiant et ON et.idEtudiant = a.idEtudiant
JOIN Seance s    ON s.idSeance    = a.idSeance
JOIN Cours c     ON c.idCours     = s.idCours
JOIN Matiere m   ON m.idMatiere   = c.idMatiere
GROUP BY et.idEtudiant, et.matricule, et.nom, et.prenoms, m.intitule;
GO

/* ============================================================
   7. PROCÉDURES STOCKÉES (appelées par l'application)
   ============================================================ */

CREATE PROCEDURE sp_InscrireEtudiant
    @idEtudiant       INT,
    @idClasse         INT,
    @fraisInscription DECIMAL(10,2) = 0
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @idAnnee INT = (SELECT idAnnee FROM Classe WHERE idClasse = @idClasse);
    IF @idAnnee IS NULL
        THROW 50010, N'Classe introuvable.', 1;

    INSERT INTO Inscription (idEtudiant, idClasse, idAnnee, fraisInscription)
    VALUES (@idEtudiant, @idClasse, @idAnnee, @fraisInscription);

    SELECT SCOPE_IDENTITY() AS idInscription;
END
GO

CREATE PROCEDURE sp_ValiderInscription
    @idInscription INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Inscription
    SET statut = N'Validée'
    WHERE idInscription = @idInscription AND statut = N'En attente';

    IF @@ROWCOUNT = 0
        THROW 50011, N'Inscription introuvable ou déjà traitée.', 1;
END
GO

CREATE PROCEDURE sp_AnnulerInscription
    @idInscription INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Inscription
    SET statut = N'Annulée'
    WHERE idInscription = @idInscription AND statut <> N'Annulée';

    IF @@ROWCOUNT = 0
        THROW 50011, N'Inscription introuvable ou déjà annulée.', 1;
END
GO

-- Les conflits sont contrôlés par le trigger TR_Seance_Controles
CREATE PROCEDURE sp_PlanifierSeance
    @idCours    INT,
    @idSalle    INT,
    @dateSeance DATE,
    @heureDebut TIME(0),
    @heureFin   TIME(0),
    @typeSeance NVARCHAR(5) = N'CM'
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Seance (idCours, idSalle, dateSeance, heureDebut, heureFin, typeSeance)
    VALUES (@idCours, @idSalle, @dateSeance, @heureDebut, @heureFin, @typeSeance);

    SELECT SCOPE_IDENTITY() AS idSeance;
END
GO

CREATE PROCEDURE sp_AnnulerSeance
    @idSeance INT
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Seance SET statut = N'Annulée' WHERE idSeance = @idSeance;
    IF @@ROWCOUNT = 0
        THROW 50012, N'Séance introuvable.', 1;
END
GO

CREATE PROCEDURE sp_EnregistrerAbsence
    @idSeance   INT,
    @idEtudiant INT,
    @justifiee  BIT = 0,
    @motif      NVARCHAR(200) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    IF EXISTS (SELECT 1 FROM Absence WHERE idSeance = @idSeance AND idEtudiant = @idEtudiant)
        UPDATE Absence
        SET justifiee = @justifiee, motif = @motif, dateSaisie = SYSDATETIME()
        WHERE idSeance = @idSeance AND idEtudiant = @idEtudiant;
    ELSE
        INSERT INTO Absence (idSeance, idEtudiant, justifiee, motif)
        VALUES (@idSeance, @idEtudiant, @justifiee, @motif);
END
GO

/* ============================================================
   8. JEU D'ESSAI
   ============================================================ */

INSERT INTO AnneeAcademique (libelle, dateDebut, dateFin, estActive) VALUES
(N'2025-2026', '2025-09-22', '2026-07-31', 0),
(N'2026-2027', '2026-09-21', '2027-07-31', 1);

INSERT INTO Filiere (codeFiliere, libelle) VALUES
(N'IGL', N'Informatique et Génie Logiciel'),
(N'RT',  N'Réseaux et Télécommunications');

INSERT INTO Niveau (codeNiveau, libelle) VALUES
(N'L1', N'Licence 1'),
(N'L2', N'Licence 2'),
(N'L3', N'Licence 3');

INSERT INTO Classe (libelle, idFiliere, idNiveau, idAnnee) VALUES
(N'L2 IGL 2026-2027', 1, 2, 2),
(N'L1 IGL 2026-2027', 1, 1, 2),
(N'L2 RT 2026-2027',  2, 2, 2);

INSERT INTO Etudiant (matricule, nom, prenoms, dateNaissance, lieuNaissance, sexe, email, telephone) VALUES
(N'ETU2026001', N'KONE',    N'Awa',     '2005-03-14', N'Abidjan',    'F', N'awa.kone@exemple.ci',      N'0700000001'),
(N'ETU2026002', N'TRAORE',  N'Moussa',  '2004-11-02', N'Bouaké',     'M', N'moussa.traore@exemple.ci', N'0700000002'),
(N'ETU2026003', N'YAO',     N'Esther',  '2005-07-21', N'Yamoussoukro','F', N'esther.yao@exemple.ci',   N'0700000003'),
(N'ETU2026004', N'DIALLO',  N'Ibrahim', '2006-01-09', N'Abidjan',    'M', N'ibrahim.diallo@exemple.ci',N'0700000004'),
(N'ETU2026005', N'BROU',    N'Grâce',   '2005-05-30', N'Daloa',      'F', N'grace.brou@exemple.ci',    N'0700000005');

INSERT INTO Inscription (idEtudiant, idClasse, idAnnee, statut, fraisInscription) VALUES
(1, 1, 2, N'Validée', 150000),
(2, 1, 2, N'Validée', 150000),
(3, 1, 2, N'Validée', 150000),
(4, 2, 2, N'Validée', 150000),
(5, 3, 2, N'En attente', 150000);

INSERT INTO Enseignant (matricule, nom, prenoms, email, grade, specialite) VALUES
(N'ENS001', N'AKA',     N'Jean-Marc', N'jm.aka@exemple.ci',     N'Docteur',   N'Algorithmique'),
(N'ENS002', N'KOUASSI', N'Patrick',   N'p.kouassi@exemple.ci',  N'Docteur',   N'Bases de données'),
(N'ENS003', N'N''GUESSAN', N'Sylvie', N's.nguessan@exemple.ci', N'Ingénieur', N'Systèmes embarqués');

INSERT INTO Matiere (codeMatiere, intitule, credits) VALUES
(N'ALGO2', N'Algorithmique avancée',                4),
(N'BDD2',  N'Base de données II',                   5),
(N'ROB2',  N'Robotique et systèmes intelligents',   4),
(N'PRG1',  N'Introduction à la programmation',      6);

INSERT INTO Salle (codeSalle, capacite, typeSalle, batiment) VALUES
(N'A1',    120, N'Amphi',              N'Bloc A'),
(N'B12',    40, N'Salle de cours',     N'Bloc B'),
(N'LABO1',  30, N'Salle informatique', N'Bloc C');

INSERT INTO Cours (volumeHoraire, idClasse, idMatiere, idEnseignant) VALUES
(30, 1, 1, 1),
(40, 1, 2, 2),
(30, 1, 3, 3),
(45, 2, 4, 1);

INSERT INTO Seance (idCours, idSalle, dateSeance, heureDebut, heureFin, typeSeance) VALUES
(1, 2, '2026-11-09', '08:00', '10:00', N'CM'),
(2, 3, '2026-11-09', '10:15', '12:15', N'TP'),
(3, 2, '2026-11-10', '08:00', '10:00', N'CM');

EXEC sp_EnregistrerAbsence @idSeance = 1, @idEtudiant = 2, @justifiee = 0;
GO

/* ============================================================
   9. TESTS RAPIDES (à exécuter séparément)
   ============================================================

-- Emploi du temps
SELECT * FROM vEmploiDuTemps ORDER BY dateSeance, heureDebut;

-- Effectifs
SELECT * FROM vEffectifClasse;

-- Absences
SELECT * FROM vAbsencesParEtudiant;

-- Doit échouer : salle B12 déjà occupée le 09/11 de 08h à 10h (erreur 50001)
EXEC sp_PlanifierSeance @idCours = 4, @idSalle = 2, @dateSeance = '2026-11-09',
                        @heureDebut = '09:00', @heureFin = '11:00';

-- Doit échouer : l'enseignant 1 est déjà en séance de 08h à 10h (erreur 50002)
EXEC sp_PlanifierSeance @idCours = 4, @idSalle = 1, @dateSeance = '2026-11-09',
                        @heureDebut = '08:30', @heureFin = '09:30';

-- Doit échouer : double inscription la même année (violation UNIQUE)
EXEC sp_InscrireEtudiant @idEtudiant = 1, @idClasse = 2;

-- Doit échouer : étudiant 4 n'est pas dans la classe de la séance 1 (erreur 50005)
EXEC sp_EnregistrerAbsence @idSeance = 1, @idEtudiant = 4;
============================================================ */
