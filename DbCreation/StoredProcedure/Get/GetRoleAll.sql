CREATE PROCEDURE [dbo].[GetRoleAll]

AS
	SELECT
		[Id],
		[Role],
		[Description]
	FROM
		[Role]
