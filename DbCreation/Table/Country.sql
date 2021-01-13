CREATE TABLE [dbo].[Country]
(
	[Id]			int IDENTITY NOT NULL, 
	[Iso]			char(2) NOT NULL, 
	[Name]			varchar(80) NOT NULL, 
	[Iso3]			char(3) NULL, 
	[NumCode]		smallint NULL, 
	[PhoneCode]		int NOT NULL, 
	PRIMARY KEY (Id)
);