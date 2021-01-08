CREATE PROCEDURE [dbo].[GetCountry]
	@id int
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
		[Id] = @id