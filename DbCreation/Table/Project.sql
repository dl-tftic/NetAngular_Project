CREATE TABLE [dbo].[Project]
(
	[Id]			int IDENTITY NOT NULL, 
	[Code]			varchar(30) NULL UNIQUE DEFAULT NULL, 
	[Name]			varchar(255) NOT NULL UNIQUE, 
	[Description]	varchar(255) NULL DEFAULT NULL, 
	[CreateDate]	date NOT NULL DEFAULT GETDATE(), 
	[CreateBy]		int NOT NULL, 
	[AddressId]		int NOT NULL,
	PRIMARY KEY (Id),
	CONSTRAINT FK_Project_Address FOREIGN KEY (AddressId) REFERENCES Address (Id)
);