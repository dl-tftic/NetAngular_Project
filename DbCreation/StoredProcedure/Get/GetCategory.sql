CREATE PROCEDURE [dbo].[GetCategory]
	@id int
AS
	SELECT 
		[Id],
		[Name],
		[Description],
		[Type],
		[CreateDate],
		[CreateBy]
	FROM
		[Category]
	WHERE
		[Id] = @id