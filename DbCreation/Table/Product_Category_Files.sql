CREATE TABLE [dbo].[Product_Category_Files]
(
	[FilesId]				int NOT NULL, 
	[Category_ProductId]	int NOT NULL, 
	PRIMARY KEY (FilesId, Category_ProductId),
	CONSTRAINT FK_FilesCategoryProduct_CategoryProduct FOREIGN KEY (Category_ProductId) REFERENCES Product_Category (Id),
	CONSTRAINT FK_FilesCategoryProduct_Files FOREIGN KEY (FilesId) REFERENCES Files (Id)
);