﻿CREATE TABLE [dbo].[Actuality]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,
	[CreatedDate] DATETIME NOT NULL,
	[UpdatedDate] DATETIME NOT NULL,
	[Name] NVARCHAR(128) NOT NULL,
	[Description] NVARCHAR(MAX) NOT NULL,
	[Url] NVARCHAR(255) NULL,
	[Date] DATETIME NULL,
	[UserDefinableId] UNIQUEIDENTIFIER NULL,
)
