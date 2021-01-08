CREATE TABLE [dbo].[Supplier]
(
	[Id]			int IDENTITY NOT NULL, 
	[Name]			varchar(255) NOT NULL UNIQUE, 
	[Description]	varchar(255) NULL DEFAULT NULL, 
	[CreateDate]	date NOT NULL DEFAULT GETDATE(), 
	[CreateBy]		int NOT NULL, 
	[AddressId]		int NOT NULL, 
	PRIMARY KEY (Id),
	CONSTRAINT FK_Supplier_Address FOREIGN KEY (AddressId) REFERENCES Address (Id)
);