CREATE PROCEDURE [dbo].[GetCityByName]
	@name varchar(80)
AS
	SELECT
		[Id],
		[CountryId], 
		[Code],
		[City]
	FROM
		[City]
	WHERE
		[City] LIKE '%' + @name + '%'
