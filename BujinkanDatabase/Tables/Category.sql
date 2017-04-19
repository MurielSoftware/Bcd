﻿CREATE TABLE [dbo].[Category]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,
	[CreatedDate] DATETIME NOT NULL,
	[UpdatedDate] DATETIME NOT NULL,
	[Name] NVARCHAR(128) NOT NULL,
	[BuiltIn] BIT NOT NULL,
	[Dicriminator] NVARCHAR(32) NOT NULL
)