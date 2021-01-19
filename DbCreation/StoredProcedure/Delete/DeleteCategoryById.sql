CREATE PROCEDURE [dbo].[DeleteCategoryById]
	@id int
AS
	DELETE FROM [Category] WHERE [Id] = id