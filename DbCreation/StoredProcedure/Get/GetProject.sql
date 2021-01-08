CREATE PROCEDURE [dbo].[GetProject]
	@id int
AS
	SELECT
		[Id],
		[Code],
		[Name],
		[Description],
		[CreateDate],
		[CreateBy],
		[AddressId]
	FROM
		[Project]
	WHERE
		[Id] = @id