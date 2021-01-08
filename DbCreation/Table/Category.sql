CREATE TABLE [dbo].[Category]
(
	[Id]			int IDENTITY NOT NULL, 
	[Name]			varchar(80) NOT NULL UNIQUE, 
	[Description]	varchar(255) NULL DEFAULT NULL, 
	[Type]			varchar(50) NULL DEFAULT NULL, 
	[CreateDate]	date NOT NULL DEFAULT GETDATE(),
	[CreateBy]		int NOT NULL, 
	PRIMARY KEY (Id)
);