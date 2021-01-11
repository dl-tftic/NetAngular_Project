USE [master]
EXEC sp_configure 'contained database authentication', 1
GO

RECONFIGURE
GO

ALTER DATABASE [Project]
SET containment = PARTIAL
GO

USE [Project]
GO
CREATE USER project_user WITH PASSWORD = 'Abc1234mydb';
GO

USE [Project]
GO
ALTER ROLE [db_owner] ADD MEMBER project_user
GO
USE [Project]
GO




GO
CREATE USER project_user FOR LOGIN project_user WITH DEFAULT_SCHEMA=[db_accessadmin]
GO
USE [Project]
GO
ALTER AUTHORIZATION ON SCHEMA::[db_accessadmin] TO project_user
GO
USE [Project]
GO
ALTER AUTHORIZATION ON SCHEMA::[db_owner] TO project_user
GO
USE [Project]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER project_user
GO

CREATE USER []
GO
