CREATE PROCEDURE [dbo].[GetProjectByAccountId]
	@accountId int
AS
	SELECT
		[Project].[Id],
		[Project].[Code],
		[Project].[Name],
		[Project].[Description],
		[Project].[CreateDate],
		[Project].[CreateBy],
		[Project].[AddressId]
	FROM
		[Project]
	INNER JOIN [Account_Project] ON [Account_Project].ProjectId = [Project].[Id]
	INNER JOIN [Account] ON [Account].[Id] = @accountId

