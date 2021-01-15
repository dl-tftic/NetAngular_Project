CREATE PROCEDURE [dbo].[GetContactInfoBySupplierId]
		@supplierId int
AS
	SELECT
		[ContactInfo].[Id],
		[ContactInfo].[ContactType],
		[ContactInfo].[ContactInformation],
		[ContactInfo].[Description]
	FROM
		[ContactInfo]
	INNER JOIN [Supplier_ContactInfo] ON [Supplier_ContactInfo].ContactInfoId = [ContactInfo].[Id]
	INNER JOIN [Supplier] ON [Supplier_ContactInfo].[SupplierId] = [Supplier].[Id]
	AND [Supplier].[Id] = @supplierId
