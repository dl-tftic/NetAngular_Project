CREATE PROCEDURE [dbo].[GetContactInfoByAccountId]
	@AccountId int
AS
	SELECT
		[ContactInfo].[Id],
		[ContactInfo].[ContactType],
		[ContactInfo].[ContactInformation],
		[ContactInfo].[Description]
	FROM
		[ContactInfo]
	INNER JOIN [Account_ContactInfo] ON [Account_ContactInfo].ContactInfoId = [ContactInfo].[Id]
	INNER JOIN [Account] ON [Account_ContactInfo].AccountId = [Account].[Id]
	AND [Account].[Id] = @AccountId