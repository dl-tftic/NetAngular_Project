CREATE TABLE [dbo].[Files]
(
	[Id]				int IDENTITY NOT NULL, 
	[Name]				varchar(80) NOT NULL UNIQUE, 
	[FileName]			varchar(255) NOT NULL, 
	[FileExension]		varchar(20) NOT NULL, 
	[FileByte]			varbinary(max) NOT NULL, 
	[FileSize]			bigint NOT NULL, 
	[FileLinkId]		varchar(80) NULL DEFAULT NULL, 
	[Description]		varchar(255) NULL DEFAULT NULL, 
	[CreateDate]		date NOT NULL DEFAULT GETDATE(), 
	[CreateBy]			int NOT NULL, 
	PRIMARY KEY (Id)
);