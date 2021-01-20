CREATE PROCEDURE [dbo].[GetProjectAll]

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
