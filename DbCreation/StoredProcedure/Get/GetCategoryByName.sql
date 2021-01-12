CREATE PROCEDURE [dbo].[GetCategoryByName]
	@name varchar(80)
AS
	SELECT 
		[Id],
		[Name],
		[Description],
		[Type],
		[CreateDate],
		[CreateBy]
	FROM
		[Category]
	WHERE
		[Name] LIKE '%' + @name + '%'
