CREATE PROCEDURE [dbo].[GetFile]
	@id int = 0
AS
	SELECT 
		[Id],
		[Name],
		[FileName],
		[FileExension],
		[FileByte],
		[FileSize],
		[FileLinkId],
		[Description],
		[CreateDate],
		[CreateBy]
	FROM 
		Files 
	WHERE 
		ID = @id