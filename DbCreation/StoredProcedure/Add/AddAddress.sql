CREATE PROCEDURE [dbo].[AddAddress]
	@Street		varchar(50), 
	@Number		varchar(10), 
	@Box		int = null, 
	@CityId		int
AS
	DECLARE @rtn int;

	INSERT INTO [Address] ([Street], [Number], [Box], [CityId])
	VALUES (@Street, @Number, @Box, @CityId)
	SET @rtn = SCOPE_IDENTITY();
	SELECT @rtn;
	RETURN @rtn;