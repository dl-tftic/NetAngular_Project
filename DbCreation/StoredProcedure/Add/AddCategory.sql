CREATE PROCEDURE [dbo].[AddCategory]
	@Name			varchar(80),
	@Description	varchar(255) = NULL,
	@Type			varchar(50) = NULL, 
	@CreateBy		int
AS
	INSERT INTO [Category] ([Name], [Description], [Type], [CreateBy])
	VALUES (@Name, @Description, @Type, @CreateBy)
	SELECT SCOPE_IDENTITY();
	GO;
--RETURN 0
