CREATE PROCEDURE [dbo].[GetProductCategories]
	@productId int
AS
	SELECT
		[Id],
		[CategoryId],
		[ParentCategoryProductId],
		[ProductId]
	FROM
		[Product_Category]
	WHERE
		[Product_Category].[ProductId] = @productId
	ORDER BY [Id]