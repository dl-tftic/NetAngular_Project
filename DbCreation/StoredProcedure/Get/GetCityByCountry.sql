CREATE PROCEDURE [dbo].[GetCityByCountry]
	@CountryId int
AS
	SELECT
		[Id],
		[CountryId], 
		[Code],
		[City]
	FROM
		[City]
	WHERE
		[CountryId] = @CountryId
