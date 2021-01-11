-- IF OBJECT_ID('[dbo].[AddAccount]', 'P') IS NOT NULL
-- DROP PROCEDURE [dbo].[AddAccount]
-- GO

CREATE PROCEDURE [dbo].[AddAccount]
	@Login		varchar(80) , 
	@Activate	bit = 1, 
	@LastName	varchar(50) , 
	@FirstName	varchar(50) , 
	@Password	varchar(50) , 
	@RoleID		int,
	@AddressId	int,
	@CreateBy	int = 0
AS
	DECLARE @rtn int;
	DECLARE @salt varchar(32), @passWithSalt binary(32)
	SET @salt = dbo.GenerateSalt(newid());
	SET @passWithSalt = HASHBYTES('SHA2_256', CONCAT(@Password, @salt));
	PRINT @passWithSalt

	INSERT INTO [Account] 
		(
			[Login], 
			[Activate], 
			[LastName], 
			[FirstName], 
			[Password], 
			[Salt], 
			[RoleID], 
			[AddressId], 
			[CreateBy]
		)
	VALUES 
		(
			@Login, 
			@Activate, 
			@LastName, 
			@FirstName, 
			@passWithSalt, 
			@salt, 
			@RoleID, 
			@AddressId, 
			@CreateBy
		)
	SET @rtn = SCOPE_IDENTITY();
	SELECT @rtn;
	RETURN @rtn;