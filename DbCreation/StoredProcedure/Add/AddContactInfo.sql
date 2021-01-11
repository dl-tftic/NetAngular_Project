CREATE PROCEDURE [dbo].[AddContactInfo]
	@ContactType			varchar(50),
	@ContactInformation		varchar(80),
	@Description			varchar(80) = null
AS
	DECLARE @rtn int;

	INSERT INTO [ContactInfo] ([ContactType], [ContactInformation], [Description])
	VALUES (@ContactType, @ContactInformation, @Description)
	SET @rtn = SCOPE_IDENTITY();
	SELECT @rtn;
	RETURN @rtn;