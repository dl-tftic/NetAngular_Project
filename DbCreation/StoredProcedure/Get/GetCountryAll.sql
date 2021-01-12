CREATE PROCEDURE [dbo].[GetCountryAll]
	
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