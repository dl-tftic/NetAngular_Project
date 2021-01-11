CREATE PROCEDURE [dbo].[AddSupplierContactInfo]
	@SupplierId int,
	@ContactInfoId int
AS
	DECLARE @rtn int;

	INSERT INTO [Supplier_ContactInfo] ([SupplierId], [ContactInfoId])
	VALUES (@supplierId, @contactInfoId)

	SET @rtn = SCOPE_IDENTITY();
	SELECT @rtn;
	RETURN @rtn;
