CREATE PROCEDURE [dbo].[AddProjectCategoryProduct]
	@Project_CategoryId int,
	@ProductId int,
	@Code varchar(50) = null,
	@SupplierId int

AS
	INSERT INTO [Project_Category_Product] ([Project_CategoryId], [ProductId], [Code], [SupplierId])
	VALUES (@Project_CategoryId, @ProductId, @Code, @SupplierId)