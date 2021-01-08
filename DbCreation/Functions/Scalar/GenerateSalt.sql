CREATE FUNCTION [dbo].[GenerateSalt]
(
	@guidParm uniqueidentifier
)
RETURNS char(32)
AS
BEGIN
	declare @saltResult varchar(32)
	set @saltResult = replace(CONVERT (VARCHAR (255), @guidParm), '-', '')
	return @saltResult
END
