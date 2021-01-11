CREATE PROCEDURE [dbo].[GetAccountAll]

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
