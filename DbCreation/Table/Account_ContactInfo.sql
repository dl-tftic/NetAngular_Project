CREATE TABLE [dbo].[Account_ContactInfo]
(
	[AccountId]			int NOT NULL, 
	[ContactInfoId]		int NOT NULL, 
	PRIMARY KEY (AccountId, ContactInfoId),
	CONSTRAINT FK_AccountContactInfo_Account FOREIGN KEY (AccountId) REFERENCES Account (Id),
	CONSTRAINT FK_AccountContactInfo_ContactInfo FOREIGN KEY (ContactInfoId) REFERENCES ContactInfo (Id)
);