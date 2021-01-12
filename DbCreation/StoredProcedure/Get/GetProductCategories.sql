CREATE PROCEDURE [dbo].[GetProductCategories]
	@productId int
AS
	SELECT
		[Product_Category].[Id],
		[Product_Category].[CategoryId],
		[Product_Category].[ParentCategoryProductId],
		[Product_Category].[ProductId]
	FROM
		[Product_Category]
	WHERE
		[Product_Category].[Id] = @productId
