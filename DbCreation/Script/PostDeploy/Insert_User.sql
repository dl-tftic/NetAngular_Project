USE [master];
EXEC sp_configure 'contained database authentication', 1;
GO

RECONFIGURE;
GO

ALTER DATABASE [$(DatabaseName)]
SET containment = PARTIAL
GO

USE [$(DatabaseName)]
GO
CREATE USER project_user WITH PASSWORD = 'Abc1234mydb';
GO

USE [$(DatabaseName)];
GO
ALTER ROLE [db_owner] ADD MEMBER project_user
GO

/*
DECLARE @dbName varchar(80);
SET @dbName = [$(DatabaseName)]
PRINT @dbName

DECLARE @alterDb varchar(500);
SET @alterDb = 'ALTER DATABASE ' + @dbName + '; SET containment = PARTIAL; GO;';
exec(@alterDb);

DECLARE @createUser varchar(500);
SET @createUser = 'USE ' + @dbName + '; GO; CREATE USER project_user WITH PASSWORD = ''Abc1234mydb''; GO;';
exec(@createUser);

DECLARE @alterUser varchar(500);
SET @alterUser = 'USE ' + @dbName + '; GO;ALTER ROLE [db_owner] ADD MEMBER project_user; GO;';
exec(@alterUser);
*/

