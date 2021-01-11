CREATE PROCEDURE [dbo].[GetProjectCategories]
	@projectId int
AS
	SELECT
		[Category].[Id],
		[Category].[Name],
		[Category].[Description],
		[Category].[Type],
		[Category].[CreateDate],
		[Category].[CreateBy],
		[Project_Category].[ParentProjectCategoryId],
		[Project_Category].[ProjectId]
	FROM
		[Category]
	INNER JOIN [Project_Category] ON [Project_Category].[CategoryId] = [Category].[Id]
	INNER JOIN [Project] ON [Project_Category].[ProjectId] = [Project].[Id]
	AND [Project].[Id] = @projectId