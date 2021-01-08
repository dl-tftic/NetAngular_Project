CREATE TABLE [dbo].[Project_Category_Files]
(
	[Project_CategoryId]	int NOT NULL, 
	[FilesId]				int NOT NULL, 
	PRIMARY KEY (Project_CategoryId, FilesId),
	CONSTRAINT FK_ProjectCategoryFiles_Files FOREIGN KEY (FilesId) REFERENCES Files (Id),
	CONSTRAINT FK_ProjectCategoryFiles_ProjectCategory FOREIGN KEY (Project_CategoryId) REFERENCES Project_Category (Id)
);