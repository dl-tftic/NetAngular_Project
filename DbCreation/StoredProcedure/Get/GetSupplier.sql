CREATE PROCEDURE [dbo].[GetSupplier]
	@id int
AS
	SELECT 
		[Id],
		[Name],
		[Description],
		[CreateDate],
		[CreateBy],
		[AddressId]
	FROM
		[Supplier]
	WHERE
		[Id] = @id