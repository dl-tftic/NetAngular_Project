CREATE PROCEDURE [dbo].[GetProjectCategoryProduct]
	@projectCategoryId int
AS
	SELECT 
		[Project_CategoryId],
		[ProductId],
		[Code],
		[SupplierId]
	FROM
		[Project_Category_Product]
	WHERE
		[Project_CategoryId] = @projectCategoryId