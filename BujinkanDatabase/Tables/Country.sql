﻿CREATE TABLE [dbo].[Country]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,
	[CreatedDate] DATETIME NOT NULL,
	[UpdatedDate] DATETIME NOT NULL,
	[Name] NVARCHAR(64) NOT NULL,
	[Path] NVARCHAR(255) NOT NULL
)
