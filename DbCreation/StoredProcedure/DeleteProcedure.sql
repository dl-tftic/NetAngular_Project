CREATE PROCEDURE [dbo].[DeleteProcedure]
	@procedureName varchar(80)
AS
	IF OBJECT_ID(@procedureName, 'P') IS NOT NULL  
	DECLARE @sql varchar(100);
	SET @sql = 'DROP PROCEDURE ' + @procedureName;
	EXEC(@sql);
	--DROP PROCEDURE @procedureName
	GO
--RETURN 0
