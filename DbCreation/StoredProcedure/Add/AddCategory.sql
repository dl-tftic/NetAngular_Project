CREATE PROCEDURE [dbo].[AddCategory]
	@Name			varchar(80),
	@Description	varchar(255) = NULL,
	@Type			varchar(50) = NULL, 
	@CreateBy		int
AS
	DECLARE @rtn int;

	INSERT INTO [Category] ([Name], [Description], [Type], [CreateBy])
	VALUES (@Name, @Description, @Type, @CreateBy)
	SET @rtn = SCOPE_IDENTITY();
	SELECT @rtn;
	RETURN @rtn;