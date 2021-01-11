CREATE PROCEDURE [dbo].[AddAccountProject]
	@AccountId int,
	@ProjectId int
AS
	DECLARE @rtn int;

	INSERT INTO [Account_Project] ([AccountId], [ProjectId])
	VALUES (@AccountId, @ProjectId);

	SET @rtn = SCOPE_IDENTITY();
	SELECT @rtn;
	RETURN @rtn;