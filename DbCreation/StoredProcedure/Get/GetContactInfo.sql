CREATE PROCEDURE [dbo].[GetContactInfo]
	@id int
AS
	SELECT
		[Id],
		[ContactType],
		[ContactInformation],
		[Description]
	FROM
		[ContactInfo]
	WHERE
		[Id] = @id

