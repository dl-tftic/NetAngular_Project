CREATE PROCEDURE [dbo].[AddSupplier]
	@Name			varchar(255),
	@Description	varchar(255) = null,
	@AddressId		int,
	@CreateBy		int 
	
AS
	INSERT INTO [Supplier] ([Name], [Description], [AddressId], [CreateBy])
	VALUES (@Name, @Description, @AddressId, @CreateBy)
	SELECT SCOPE_IDENTITY();
	GO;
--RETURN 0
