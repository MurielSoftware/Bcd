﻿CREATE TABLE [dbo].[DOJO]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,
	[Name] NVARCHAR(MAX) NOT NULL,
	[Description] NVARCHAR(MAX) NULL,
	[BuiltIn] BIT NOT NULL,
	[OrganizationType] INT NOT NULL,
	[CivicAssociationRegistration] NVARCHAR(MAX) NULL,
	[Ic] NVARCHAR(MAX) NULL,
	[Email] NVARCHAR(MAX) NULL,
	[Facebook] NVARCHAR(MAX) NULL
)
