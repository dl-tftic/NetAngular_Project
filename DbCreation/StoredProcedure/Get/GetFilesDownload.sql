CREATE PROCEDURE [dbo].[GetFilesDownload]
	@id int
AS
	SELECT 
		[Files].[FileByte]
	FROM 
		[Files]
	WHERE
		[Id] = @id