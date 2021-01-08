CREATE PROCEDURE [dbo].[AddContactInfo]
	@ContactType			varchar(50),
	@ContactInformation		varchar(80),
	@Description			varchar(80) = null
AS
	INSERT INTO [ContactInfo] ([ContactType], [ContactInformation], [Description])
	VALUES (@ContactType, @ContactInformation, @Description)
	SELECT SCOPE_IDENTITY();
	GO;
--RETURN 0
