CREATE TABLE [dbo].[Address]
(
	[Id]		int IDENTITY NOT NULL, 
	[Street]	varchar(50) NOT NULL, 
	[Number]	varchar(10) NOT NULL, 
	[Box]		VARCHAR(5) NULL, 
	[CityId]	int NOT NULL, 
	PRIMARY KEY (Id),
	CONSTRAINT FK_Address_City FOREIGN KEY (CityId) REFERENCES City (Id)
);