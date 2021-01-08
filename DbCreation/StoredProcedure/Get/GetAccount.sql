CREATE PROCEDURE [dbo].[GetAccount]
	@id int
AS
	SELECT 
		[Id],
		[Login],
		[Activate],
		[LastName],
		[FirstName],
		[RoleID],
		[AddressId],
		[CreateDate],
		[CreateBy]
	FROM
		[Account]
	WHERE
		[Id] = @id
