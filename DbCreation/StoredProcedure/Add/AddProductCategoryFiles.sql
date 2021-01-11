CREATE PROCEDURE [dbo].[AddProductCategoryFiles]
	@Category_ProductId int,
	@FilesId int
AS
	INSERT INTO [Product_Category_Files] ([Category_ProductId], [FilesId])
	VALUES (@Category_ProductId, @FilesId)