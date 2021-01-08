CREATE PROCEDURE [dbo].[GetCityByPostalCode]
	@postalCode varchar(12)
AS
	SELECT
		[Id],
		[CountryId], 
		[Code],
		[City]
	FROM
		[City]
	WHERE
		[Code] = @postalCode
