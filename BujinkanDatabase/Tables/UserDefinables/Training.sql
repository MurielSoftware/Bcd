﻿CREATE TABLE [dbo].[TRAINING]
(
	[Id] UNIQUEIDENTIFIER NOT NULL,
	[Day] INT NOT NULL,
	[ForChildren] BIT NOT NULL,
	[Start] DATETIME NOT NULL,
	[End] DATETIME NOT NULL,
	[Address] NVARCHAR(MAX) NULL,
	[City] NVARCHAR(MAX) NOT NULL,
	[Zipcode] NVARCHAR(MAX) NULL,
	[Gps] NVARCHAR(MAX) NULL,
	[Description] NVARCHAR(MAX) NULL,

	[UserId] UNIQUEIDENTIFIER NOT NULL,
	[CountryId] UNIQUEIDENTIFIER NULL
)
