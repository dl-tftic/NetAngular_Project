CREATE PROCEDURE [dbo].[AddProjectCategoryFiles]
	@Project_CategoryId int,
	@FilesId int
AS
	INSERT INTO [Project_Category_Files] ([Project_CategoryId], [FilesId])
	VALUES (@Project_CategoryId, @FilesId)
