CREATE TABLE [dbo].[Product_Category]
(
	[Id]						int IDENTITY NOT NULL, 
	[CategoryId]				int NOT NULL, 
	[ProductId]					int NOT NULL, 
	[ParentCategoryProductId]	int NULL
	PRIMARY KEY (Id),
	CONSTRAINT FK_CategoryProduct_Category FOREIGN KEY (CategoryId) REFERENCES Category (Id),
	CONSTRAINT FK_CategoryProduct_Product FOREIGN KEY (ProductId) REFERENCES Product (Id)
);