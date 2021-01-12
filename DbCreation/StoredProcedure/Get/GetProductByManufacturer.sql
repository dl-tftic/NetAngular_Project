CREATE PROCEDURE [dbo].[GetProductByManufacturer]
	@manufacturer varchar(80)
AS
	SELECT
		[Id],
		[Code],
		[Manufacturer],
		[Name],
		[Model],
		[Revision],
		[Description],
		[CreateDate],
		[CreateBy]
	FROM
		[Product]
	WHERE
		[Manufacturer] LIKE '%' + @manufacturer + '%'
