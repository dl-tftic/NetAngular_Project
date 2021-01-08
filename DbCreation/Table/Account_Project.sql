CREATE TABLE [dbo].[Account_Project]
(
	[AccountId]		int NOT NULL, 
	[ProjectId]		int NOT NULL, 
	PRIMARY KEY (AccountId, ProjectId),
	CONSTRAINT FK_AccountProject_Account FOREIGN KEY (AccountId) REFERENCES Account (Id),
	CONSTRAINT FK_AccountProject_Project FOREIGN KEY (ProjectId) REFERENCES Project (Id)
);