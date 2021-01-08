CREATE PROCEDURE [dbo].[GetCountryByName]
	@name varchar(80)
AS
	SELECT 
		[Id],
		[Iso],
		[Name],
		[iso3],
		[NumCode],
		[PhoneCode]
	FROM
		[Country]
	WHERE
		[Name] LIKE '%' + @name + '%'
