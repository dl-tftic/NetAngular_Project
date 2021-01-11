CREATE PROCEDURE [dbo].[AddProjectCategory]
	@ProjectId int,
	@CategoryId int,
	@ParentCategoryId int = null
AS
	DECLARE @rtn int;

	INSERT INTO [Project_Category] ([ProjectId], [CategoryId], [ParentProjectCategoryId])
	VALUES (@ProjectId, @CategoryId, @ParentCategoryId)

	SET @rtn = SCOPE_IDENTITY();
	SELECT @rtn;
	RETURN @rtn;
