CREATE PROCEDURE [dbo].[GetProjectCategories]
	@projectId int
AS
	SELECT
		[Project_Category].[Id],
		[Project_Category].[CategoryId],
		[Project_Category].[ParentProjectCategoryId],
		[Project_Category].[ProjectId]
	FROM
		[Project_Category]
	WHERE
		[Project_Category].[Id] = @projectId