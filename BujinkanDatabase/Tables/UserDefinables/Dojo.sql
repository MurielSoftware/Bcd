CREATE TABLE [dbo].[Dojo]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,
	[Name] NVARCHAR(128) NOT NULL,
	[Description] NVARCHAR(MAX) NULL,
	[BuiltIn] BIT NOT NULL,
	[OrganizationType] INT NOT NULL,
	[CivicAssociationRegistration] NVARCHAR(64) NULL,
	[Ic] NVARCHAR(64) NULL,
	[Email] NVARCHAR(64) NULL,
	[Facebook] NVARCHAR(MAX) NULL
)
