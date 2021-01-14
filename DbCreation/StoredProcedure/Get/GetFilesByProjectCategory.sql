CREATE PROCEDURE [dbo].[GetFilesByProjectCategory]
	@projectCategoryId int
AS
	SELECT 
		[Files].[Id],
		[Files].[Name],
		[Files].[FileName],
		[Files].[FileExension],
		[Files].[FileByte],
		[Files].[FileSize],
		[Files].[FileLinkId],
		[Files].[Description],
		[Files].[CreateDate],
		[Files].[CreateBy]
	FROM 
		[Files]
	INNER JOIN [Project_Category_Files] ON [Project_Category_Files].[FilesId] = [Files].[Id]
	INNER JOIN [Project_Category] ON [Project_Category].[Id] = [Project_Category_Files].[Project_CategoryId]
	AND [Project_Category].[Id] = @projectCategoryId;
