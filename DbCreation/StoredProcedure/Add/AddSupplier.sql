CREATE PROCEDURE [dbo].[AddSupplier]
	@Name			varchar(255),
	@Description	varchar(255) = null,
	@AddressId		int,
	@CreateBy		int 
	
AS
	DECLARE @rtn int;

	INSERT INTO [Supplier] ([Name], [Description], [AddressId], [CreateBy])
	VALUES (@Name, @Description, @AddressId, @CreateBy)
	SET @rtn = SCOPE_IDENTITY();
	SELECT @rtn;
	RETURN @rtn;