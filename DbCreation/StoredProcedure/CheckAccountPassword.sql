CREATE PROCEDURE [dbo].[CheckAccountPassword]
	@login varchar(80),
	@password varchar(50)
AS
	SELECT 
		[Id]
	FROM 
		[Account]
	WHERE 
		[Login] = @login
	AND [Password] = HASHBYTES('SHA2_256', CONCAT(@password, [Salt]));

