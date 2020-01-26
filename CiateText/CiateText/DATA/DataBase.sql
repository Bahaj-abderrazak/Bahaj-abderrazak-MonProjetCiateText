USE master
GO
IF DB_ID('db_cahier_texte') IS NOT NULL
BEGIN
	DROP DATABASE db_cahier_texte
END
GO
CREATE DATABASE db_cahier_texte
GO
USE db_cahier_texte
GO

CREATE TABLE DirectionRegionale
(
	IdDr INT NOT NULL IDENTITY PRIMARY KEY,
	Nom NVARCHAR(99) NOT NULL UNIQUE,
	Adresse NVARCHAR(255)
)
GO
CREATE TABLE Etablissement
(
	IdEtablissement INT NOT NULL IDENTITY PRIMARY KEY,
	Nom NVARCHAR(99) NOT NULL UNIQUE,
	Adresse NVARCHAR(255),
	IdDr INT NOT NULL REFERENCES DirectionRegionale(IdDr)
)
GO
CREATE TABLE Formateur
(
	Matricule INT NOT NULL PRIMARY KEY,
	Cin NVARCHAR(15) NOT NULL UNIQUE,
	Nom NVARCHAR(50) NOT NULL,
	Prenom NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE TypeFormation
(
	IdTF INT NOT NULL IDENTITY PRIMARY KEY,
	Nom NVARCHAR(50) NOT NULL UNIQUE
)
GO
CREATE TABLE ModeFormation
(
	IdMF INT NOT NULL IDENTITY PRIMARY KEY,
	Nom NVARCHAR(50) NOT NULL UNIQUE
)
GO
CREATE TABLE Niveau
(
	CodeNiveau NVARCHAR(5) NOT NULL PRIMARY KEY,
	Nom NVARCHAR(50) NOT NULL UNIQUE
)
GO
CREATE TABLE Filiere
(
	CodeFiliere NVARCHAR(10) NOT NULL PRIMARY KEY,
	Nom NVARCHAR(99) NOT NULL UNIQUE,
	CodeNiveau NVARCHAR(5) NOT NULL REFERENCES Niveau(CodeNiveau)
)
GO
CREATE TABLE Groupe
(
	NumeroGroupe INT NOT NULL IDENTITY PRIMARY KEY,
	Nom NVARCHAR(99) NOT NULL UNIQUE,
	Annee INT NOT NULL DEFAULT 1 CHECK (Annee IN (1, 2, 3)),
	IdTF INT NOT NULL REFERENCES TypeFormation(IdTF),
	IdMF INT NOT NULL REFERENCES ModeFormation(IdMF),
	IdEtablissement INT NOT NULL REFERENCES Etablissement(IdEtablissement)
)
GO
CREATE TABLE Stagiaire
(
	NumInscription NVARCHAR(20) NOT NULL PRIMARY KEY,
	Nom NVARCHAR(50) NOT NULL,
	Prenom NVARCHAR(50) NOT NULL,
	NumeroGroupe INT NOT NULL REFERENCES Groupe(NumeroGroupe)
)
GO
CREATE TABLE Module
(
	NumeroModule INT NOT NULL IDENTITY PRIMARY KEY,
	CodeModule NVARCHAR(7) NOT NULL,
	Nom NVARCHAR(99) NOT NULL
)
GO
CREATE TABLE ModuleFiliere
(
	IdMF INT NOT NULL IDENTITY PRIMARY KEY,
	CodeFiliere NVARCHAR(10) NOT NULL REFERENCES Filiere(CodeFiliere),
	NumeroModule INT NOT NULL REFERENCES Module(NumeroModule),
	Annee INT NOT NULL DEFAULT 1 CHECK (Annee IN (1, 2, 3)),
	MasseHoraire INT NOT NULL CHECK (MasseHoraire > 0)
)
GO
CREATE TABLE Affectation
(
	Matricule INT NOT NULL REFERENCES Formateur(Matricule),
	NumeroGroupe INT NOT NULL REFERENCES Groupe(NumeroGroupe),
	NumeroModule INT NOT NULL REFERENCES Module(NumeroModule),
	Annee INT NOT NULL,

	CONSTRAINT Pk_Affectation PRIMARY KEY (Matricule, NumeroGroupe, NumeroModule)
)
GO
CREATE TABLE Jour
(
	Jour NVARCHAR(15) NOT NULL PRIMARY KEY
)
GO
CREATE TABLE EmploisTemps
(
	IdET INT NOT NULL IDENTITY PRIMARY KEY,
	Jour NVARCHAR(15) NOT NULL REFERENCES Jour(Jour),
	HeureDebut TIME NOT NULL CHECK (HeureDebut >= '08:30'),
	HeureFin TIME NOT NULL CHECK (HeureFin <= '18:30'),
	Matricule INT NOT NULL REFERENCES Formateur(Matricule),
	NumeroGroupe INT NOT NULL REFERENCES Groupe(NumeroGroupe)
)
GO
CREATE TABLE Realisation
(
	IdRealisation INT NOT NULL IDENTITY PRIMARY KEY,
	DateRealisation DATE NOT NULL,
	IdET INT NOT NULL REFERENCES EmploisTemps(IdET),
	NumeroModule INT NOT NULL REFERENCES Module(NumeroModule),
	Contenu NVARCHAR(255) NOT NULL
)
GO
CREATE TABLE Absence
(
	IdRealisation INT NOT NULL REFERENCES Realisation(IdRealisation),
	NumInscription NVARCHAR(20) REFERENCES Stagiaire(NumInscription),

	CONSTRAINT Pk_Absence PRIMARY KEY(IdRealisation, NumInscription)
)
GO

CREATE TABLE Users
(
	Login NVARCHAR(35) NOT NULL,
	Password NVARCHAR(35) NOT NULL,
	CONSTRAINT PK_User PRIMARY KEY(Login)
)
GO
INSERT INTO Users VALUES (N'User 1',N'123456')
GO
INSERT INTO DirectionRegionale VALUES (N'Souss Massa Darâa', NULL)
GO
INSERT INTO Etablissement VALUES (N'ISTA TINGHIR', NULL, 1)
GO
INSERT INTO Formateur VALUES (14211, N'HA136957', N'EL HADIRI', N'Omar')
GO
INSERT INTO TypeFormation VALUES (N'Résidentielle'), (N'Alternée')
GO
INSERT INTO ModeFormation VALUES (N'Cours de Jour'), (N'Cours de Soir')
GO
INSERT INTO Niveau VALUES (N'TS', N'Technicien Specialisé'), (N'T', N'Technicien'), (N'Q', N'Qualification'), (N'S', N'Specialisation')
GO
INSERT INTO Filiere VALUES (N'TDI', N'Techniques en Développement Informatique', N'TS')
GO
INSERT INTO Groupe VALUES (N'TDI201', 2, 1, 1, 1)
GO
INSERT INTO Stagiaire VALUES (N'1998', N'Bahaj', N'Abderrazak', 1)
GO
INSERT INTO Stagiaire VALUES (N'1997', N'kamal', N'Omar', 1),(N'1996', N'Samir', N'Ilyas', 1)
GO
INSERT INTO Module VALUES (N'M08', N'Bases de Données'), (N'M09', N'Développement d''Application Client/Serveur'), (N'M10', N'Développement Web Côté Client')
GO
INSERT INTO ModuleFiliere VALUES (N'TDI', 1, 2, 140), (N'TDI', 2, 2, 120), (N'TDI', 3, 2, 120)
GO
INSERT INTO Affectation VALUES (14211, 1, 1, 2019), (14211, 1, 2, 2019), (14211, 1, 3, 2019)
GO
INSERT INTO Jour VALUES (N'Lundi'), (N'Mardi'), (N'Mercredi'), (N'Jeudi'), (N'Vendredi'), (N'Samedi'), (N'Dimanche')
GO
INSERT INTO EmploisTemps VALUES (N'Lundi', '13:30', '18:30', 14211, 1), (N'Mardi', '13:30', '18:30', 14211, 1), (N'Mercredi', '13:30', '18:30', 14211, 1), (N'Jeudi', '13:30', '18:30', 14211, 1)
GO
INSERT INTO Realisation VALUES ('2019-12-09', 1, 1, N'Présentation du module'), ('2019-12-10', 2, 2, N'Présentation du module'), ('2019-12-11', 3, 1, N'Initiation à l''algébre relationnelle'), ('2019-12-12', 4, 2, N'Présentation du mode connecté')
GO
INSERT INTO Absence VALUES (2, N'1998'), (3, N'1998')
GO


CREATE PROCEDURE PS_EMPLOIS
(
	@NomGroup NVARCHAR(99)
)
As
BEGIN
	SELECT DR.Nom,Et.Nom,G.Nom,G.Annee,E.Jour,E.HeureDebut,E.HeureFin,F.Matricule,F.Cin,F.Nom,F.Prenom
	FROM DirectionRegionale DR 
	INNER JOIN Etablissement AS Et ON Et.IdDr = DR.IdDr
	INNER JOIN Groupe AS G ON G.IdEtablissement = Et.IdEtablissement
	INNER JOIN EmploisTemps AS E ON E.NumeroGroupe = G.NumeroGroupe
	INNER JOIN Formateur AS F ON F.Matricule = E.Matricule
	WHERE G.Nom LIKE @NomGroup
	return 0
END
GO



CREATE PROCEDURE PS_REALISATION
(
	@NomGroup NVARCHAR(99)
)
As
BEGIN
	SELECT Et.Nom,DR.Nom,G.Nom,G.Annee,AF.Matricule,M.Nom,M.CodeModule,R.IdRealisation,R.DateRealisation,R.Contenu
	FROM DirectionRegionale DR 
		INNER JOIN Etablissement AS Et ON Et.IdDr = DR.IdDr
		INNER JOIN Groupe AS G ON G.IdEtablissement = Et.IdEtablissement
		INNER JOIN Affectation AS AF ON AF.NumeroGroupe = G.NumeroGroupe
		INNER JOIN Module AS M ON AF.NumeroModule = M.NumeroModule
		INNER JOIN Realisation AS R ON R.NumeroModule = M.NumeroModule
	WHERE G.Nom LIKE @NomGroup
	return 0
END

GO



SELECT * FROM Absence
SELECT * FROM Affectation
SELECT * FROM DirectionRegionale
SELECT * FROM EmploisTemps
SELECT * FROM Etablissement
SELECT * FROM Filiere
SELECT * FROM Formateur
SELECT * FROM Groupe
SELECT * FROM Jour
SELECT * FROM ModeFormation
SELECT * FROM Module
SELECT * FROM ModuleFiliere
SELECT * FROM Niveau
SELECT * FROM Realisation
SELECT * FROM Stagiaire
SELECT * FROM TypeFormation
GO