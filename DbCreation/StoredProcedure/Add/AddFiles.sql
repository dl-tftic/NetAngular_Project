CREATE PROCEDURE [dbo].[AddFiles]
	@Name				varchar(80),
	@FileName			varchar(255),
	@FileExension		varchar(20),
	@FileByte			varbinary(max),
	@FileSize			bigint,
	@FileLinkId			varchar(80) = null,
	@Description		varchar(255) = null,
	@CreateBy			int
AS
	INSERT INTO [Files] ([Name], [FileName], [FileExension], [FileByte], [FileSize], [FileLinkId], [Description], [CreateBy])
	VALUES (@Name, @FileName, @FileExension, @FileByte, @FileSize, @FileLinkId, @Description, @CreateBy)
	SELECT SCOPE_IDENTITY();

--RETURN 0
