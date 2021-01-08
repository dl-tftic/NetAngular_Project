CREATE TABLE [dbo].[ContactInfo]
(
	[Id]					int IDENTITY NOT NULL, 
	[ContactType]			varchar(50) NOT NULL, 
	[ContactInformation]	varchar(80) NOT NULL, 
	[Description]			varchar(80) NULL, 
	PRIMARY KEY (Id)
);