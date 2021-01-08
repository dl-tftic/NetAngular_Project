CREATE PROCEDURE [dbo].[GetCity]
	@id int
AS
	SELECT
		[Id],
		[CountryId], 
		[Code],
		[City]
	FROM
		[City]
	WHERE
		[Id] = @id
