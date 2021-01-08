CREATE PROCEDURE [dbo].[GetCountryByCode]
	@Iso char(2)
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
		[Iso] = @Iso
