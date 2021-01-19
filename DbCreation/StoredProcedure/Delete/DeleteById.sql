CREATE PROCEDURE [dbo].[DeleteById]
	@tableName nvarchar(128),
	@id int
AS
	DECLARE @Sql NVARCHAR(MAX);

	SET @Sql = N'DELETE FROM ' + @tableName +' WHERE [Id] = ' 

	EXEC (@Sql + @id)