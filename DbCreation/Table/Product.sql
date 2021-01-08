CREATE TABLE [dbo].[Product]
(
	[Id]			int IDENTITY NOT NULL, 
	[Code]			varchar(30) NULL DEFAULT NULL, 
	[Manufacturer]	varchar(80) NOT NULL, 
	[Name]			varchar(255) NOT NULL UNIQUE, 
	[Model]			varchar(80) NULL DEFAULT NULL, 
	[Revision]		varchar(10) NULL DEFAULT NULL, 
	[Description]	varchar(255) NULL DEFAULT NULL, 
	[CreateDate]	date NOT NULL DEFAULT GETDATE(), 
	[CreateBy]		int NOT NULL, 
	PRIMARY KEY (Id)
);