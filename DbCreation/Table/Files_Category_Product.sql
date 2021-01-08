CREATE TABLE [dbo].[Files_Category_Product]
(
	[FilesId]				int NOT NULL, 
	[Category_ProductId]	int NOT NULL, 
	PRIMARY KEY (FilesId, Category_ProductId),
	CONSTRAINT FK_FilesCategoryProduct_CategoryProduct FOREIGN KEY (Category_ProductId) REFERENCES Category_Product (Id),
	CONSTRAINT FK_FilesCategoryProduct_Files FOREIGN KEY (FilesId) REFERENCES Files (Id)
);