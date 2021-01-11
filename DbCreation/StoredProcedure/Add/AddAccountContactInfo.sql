CREATE PROCEDURE [dbo].[AddAccountContactInfo]
	@AccountId int,
	@ContactInfoId int
AS
	DECLARE @rtn int;

	INSERT INTO [Account_ContactInfo] ([AccountId], [ContactInfoId])
	VALUES (@AccountId, @ContactInfoId)

	SET @rtn = SCOPE_IDENTITY();
	SELECT @rtn;
	RETURN @rtn;