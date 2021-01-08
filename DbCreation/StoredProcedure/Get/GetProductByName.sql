CREATE PROCEDURE [dbo].[GetProductByName]
	@name varchar(255)
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
		[Name] LIKE '%' + @name + '%'