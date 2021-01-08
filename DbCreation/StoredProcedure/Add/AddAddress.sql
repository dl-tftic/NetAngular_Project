CREATE PROCEDURE [dbo].[AddAddress]
	@Street		varchar(50), 
	@Number		varchar(10), 
	@Box		int = null, 
	@CityId		int
AS
	INSERT INTO [Address] ([Street], [Number], [Box], [CityId])
	VALUES (@Street, @Number, @Box, @CityId)
	SELECT SCOPE_IDENTITY();
	GO;
--RETURN 0
