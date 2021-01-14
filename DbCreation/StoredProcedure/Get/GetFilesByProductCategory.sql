CREATE PROCEDURE [dbo].[GetFilesByProductCategory]
	@productCategoryId int
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
	INNER JOIN [Product_Category_Files] ON [Product_Category_Files].[FilesId] = [Files].[Id]
	INNER JOIN [Product_Category] ON [Product_Category].[Id] = [Product_Category_Files].[Category_ProductId]
	AND [Product_Category].[Id] = @productCategoryId;