CREATE PROCEDURE [dbo].[AddProject]
	@Code			varchar(30) = NULL,
	@Name			varchar(255),
	@Description	varchar(255) = NULL,
	@CreateBy		int,
	@AddressId		int
AS
	INSERT INTO [Project] ([Code], [Name], [Description], [CreateBy], [AddressId])
	VALUES (@Code, @Name, @Description, @CreateBy, @AddressId)
	SELECT SCOPE_IDENTITY();
	GO;
--RETURN 0
