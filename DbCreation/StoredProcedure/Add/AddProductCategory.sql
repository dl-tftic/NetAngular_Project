CREATE PROCEDURE [dbo].[AddProductCategory]
	@ProductId int,
	@CategoryId int,
	@ParentCategoryId int = null
AS
	DECLARE @rtn int;

	INSERT INTO [Product_Category] ([ProductId], [CategoryId], [ParentCategoryProductId])
	VALUES (@ProductId, @CategoryId, @ParentCategoryId)

	SET @rtn = SCOPE_IDENTITY();
	SELECT @rtn;
	RETURN @rtn;
