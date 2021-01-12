CREATE PROCEDURE [dbo].[GetProjectCategories]
	@projectId int
AS
	SELECT
		[Id],
		[CategoryId],
		[ParentProjectCategoryId],
		[ProjectId]
	FROM
		[Project_Category]
	WHERE
		[Project_Category].[Id] = @projectId