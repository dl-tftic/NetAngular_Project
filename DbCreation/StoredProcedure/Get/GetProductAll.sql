CREATE PROCEDURE [dbo].[GetProductAll]
	
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