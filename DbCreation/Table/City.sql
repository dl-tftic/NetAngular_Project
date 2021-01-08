CREATE TABLE [dbo].[City]
(
	[Id]			int IDENTITY NOT NULL, 
	[CountryId]		int NOT NULL, 
	[Code]			varchar(12) NOT NULL, 
	[City]			varchar(80) NOT NULL, 
	PRIMARY KEY (Id),
	CONSTRAINT FK_City_CountryId FOREIGN KEY (CountryId) REFERENCES Country (Id)
);