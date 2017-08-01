﻿CREATE TABLE [dbo].[LINK]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,
	[CreatedDate] DATETIME NOT NULL,
	[UpdatedDate] DATETIME NOT NULL,
	[Name] NVARCHAR(MAX) NOT NULL,
	[Url] NVARCHAR(MAX) NULL,
	[Description] NVARCHAR(MAX) NULL,
	[Discriminator] NVARCHAR(128) NOT NULL,

	[CategoryId] UNIQUEIDENTIFIER NOT NULL
)
