﻿CREATE TABLE [dbo].[CATEGORY]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,
	[Name] NVARCHAR(128) NOT NULL,
	[BuiltIn] BIT NOT NULL,
	[Dicriminator] NVARCHAR(128) NOT NULL
)
