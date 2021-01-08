CREATE PROCEDURE [dbo].[GetAccountByLogin]
	@login varchar(80)
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
		[Login] = @login
