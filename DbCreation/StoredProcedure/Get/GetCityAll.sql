CREATE PROCEDURE [dbo].[GetCityAll]

AS
	SELECT
		[Id],
		[CountryId], 
		[Code],
		[City]
	FROM
		[City]