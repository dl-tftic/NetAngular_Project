CREATE TABLE [dbo].[Project_Category]
(
	[Id]							int IDENTITY NOT NULL, 
	[ProjectId]						int NOT NULL, 
	[CategoryId]					int NOT NULL, 
	[ParentProjectCategoryId]		int NULL, 
	PRIMARY KEY (Id),
	CONSTRAINT FK_ProjectCategory_Category FOREIGN KEY (CategoryId) REFERENCES Category (Id),
	CONSTRAINT FK_ProjectCategory_Project FOREIGN KEY (ProjectId) REFERENCES Project (Id)
);