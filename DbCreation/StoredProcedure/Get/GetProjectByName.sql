CREATE PROCEDURE [dbo].[GetProjectByName]
	@name varchar(255)
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
		[Name] LIKE '%' + @name + '%'
