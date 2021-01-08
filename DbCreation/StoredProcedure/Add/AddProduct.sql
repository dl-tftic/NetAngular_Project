﻿CREATE PROCEDURE [dbo].[AddProduct]
	@Code			varchar(30) = null,
	@Manufacturer	varchar(80),
	@Name			varchar(255),
	@Model			varchar(80) = null,
	@Revision		varchar(10) = null,
	@Description	varchar(255) = null,
	@CreateBy		int
AS
	INSERT INTO [Product] ([Code], [Manufacturer], [Name], [Model], [Revision], [Description], [CreateBy])
	VALUES (@Code, @Manufacturer, @Name, @Model, @Revision, @Description, @CreateBy)
	SELECT SCOPE_IDENTITY();
	GO;
--RETURN 0
