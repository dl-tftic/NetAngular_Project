CREATE PROCEDURE [dbo].[GetProduct]
	@id int
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
		[Id] = @id