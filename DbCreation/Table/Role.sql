CREATE TABLE [dbo].[Role]
(
	[Id]			int IDENTITY NOT NULL, 
	[Role]			varchar(30) NOT NULL UNIQUE, 
	[Description]	varchar(255) NULL, 
	PRIMARY KEY (Id)
);