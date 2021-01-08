CREATE TABLE [dbo].[Supplier_ContactInfo]
(
	[SupplierId]		int NOT NULL,
	[ContactInfoId]		int NOT NULL,
	PRIMARY KEY (SupplierId, ContactInfoId),
	CONSTRAINT FK_SupplierContactInfo_ContactInfo FOREIGN KEY (ContactInfoId) REFERENCES ContactInfo (Id),
	CONSTRAINT FK_SupplierContactInfo_Supplier FOREIGN KEY (SupplierId) REFERENCES Supplier (Id)
);