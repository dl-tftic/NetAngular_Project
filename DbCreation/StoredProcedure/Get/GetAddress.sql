CREATE PROCEDURE [dbo].[GetAddress]
	@id int = 0
AS
	SELECT 
		[Id],
		[Street],
		[Number],
		[Box],
		[CityId]
	FROM 
		[Address]
	WHERE 
		ID = @id
RETURN 0
