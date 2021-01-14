CREATE PROCEDURE [dbo].[GetProductByProjectCategory]
	@projectCategoryId int
AS
	SELECT
		[Product].[Id],
		[Product].[Code],
		[Product].[Manufacturer],
		[Product].[Name],
		[Product].[Model],
		[Product].[Revision],
		[Product].[Description],
		[Product].[CreateDate],
		[Product].[CreateBy]
	FROM
		[Product]
	INNER JOIN [Project_Category_Product] ON [Project_Category_Product].[ProductId] = [Product].[Id]
	INNER JOIN [Project_Category] ON [Project_Category].[Id] = [Project_Category_Product].[Project_CategoryId]
	AND [Project_Category].[Id] = @projectCategoryId;