CREATE PROCEDURE [dbo].[GetCategoryAll]
	
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
