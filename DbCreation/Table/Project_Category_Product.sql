CREATE TABLE [dbo].[Project_Category_Product]
(
	[Project_CategoryId]	int NOT NULL, 
	[ProductId]				int NOT NULL, 
	[Code]					varchar(50) NULL, 
	[SupplierId]			int NOT NULL, 
	PRIMARY KEY (Project_CategoryId, ProductId),
	CONSTRAINT FK_ProjectCategoryProduct_Product FOREIGN KEY (ProductId) REFERENCES Product (Id),
	CONSTRAINT FK_ProjectCategoryProduct_ProjectCategory FOREIGN KEY (Project_CategoryId) REFERENCES Project_Category (Id),
	CONSTRAINT FK_ProjectCategoryProduct_Supplier FOREIGN KEY (SupplierId) REFERENCES Supplier (Id)
);