CREATE TABLE [dbo].[Role]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,
	[CreatedDate] DATETIME NOT NULL,
	[UpdatedDate] DATETIME NOT NULL,
	[Name] NVARCHAR (128) NOT NULL,
	[DojoCreation] BIT NOT NULL,
	[UserCreation] BIT NOT NULL,
	[RoleCreation] BIT NOT NULL,
	[MenuCreation] BIT NOT NULL,
	[CreateUpdateDeleteAll] BIT NOT NULL
)
