CREATE PROCEDURE [dbo].[GetRole]
	@id int
AS
	SELECT
		[Id],
		[Role],
		[Description]
	FROM
		[Role]
	WHERE
		[Id] = @id