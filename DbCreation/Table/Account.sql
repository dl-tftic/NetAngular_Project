CREATE TABLE [dbo].[Account]
(
	[Id]			int IDENTITY NOT NULL, 
	[Login]			varchar(80) NOT NULL UNIQUE, 
	[Activate]		bit DEFAULT '1' NOT NULL, 
	[LastName]		varchar(50) NOT NULL, 
	[FirstName]		varchar(50) NOT NULL, 
	[Password]		BINARY(32) NOT NULL, 
	[Salt]			char(32) NOT NULL, 
	[RoleID]		int NOT NULL, 
	[AddressId]		int NOT NULL, 
	[CreateDate]	date NOT NULL DEFAULT GETDATE(), 
	[CreateBy]		int NOT NULL, 
	PRIMARY KEY (Id),
	CONSTRAINT FK_Account_Address FOREIGN KEY (AddressId) REFERENCES Address (Id),
	CONSTRAINT FK_Account_Role FOREIGN KEY (RoleID) REFERENCES Role (Id)
);