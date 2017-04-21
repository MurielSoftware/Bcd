/* Training */
ALTER TABLE [dbo].[Training] ADD CONSTRAINT [FK_Training_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] (Id)
GO
ALTER TABLE [dbo].[Training] ADD CONSTRAINT [FK_Training_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] (Id)
GO
ALTER TABLE [dbo].[Training] ADD  CONSTRAINT [FK_Training_UserDefinable] FOREIGN KEY([Id]) REFERENCES [dbo].[UserDefinable] ([Id])
GO

/* User */
ALTER TABLE [dbo].[User] ADD CONSTRAINT [FK_User_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] (Id)
GO
ALTER TABLE [dbo].[User] ADD CONSTRAINT [FK_User_Dojo] FOREIGN KEY ([DojoId]) REFERENCES [dbo].[Dojo] (Id)
GO
ALTER TABLE [dbo].[User] ADD CONSTRAINT [FK_User_Role] FOREIGN KEY ([RoleId]) REFERENCES [dbo].[Role] (Id)
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [FK_User_UserDefinable] FOREIGN KEY([Id]) REFERENCES [dbo].[UserDefinable] ([Id])
GO

/* Event */
ALTER TABLE [dbo].[Event] ADD CONSTRAINT [FK_Event_Country] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Country] (Id)
GO
ALTER TABLE [dbo].[Event] ADD  CONSTRAINT [FK_Event_UserDefinable] FOREIGN KEY([Id]) REFERENCES [dbo].[UserDefinable] ([Id])
GO

/* Blog */
ALTER TABLE [dbo].[Blog] ADD CONSTRAINT [FK_Blog_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] (Id)
GO
ALTER TABLE [dbo].[Blog] ADD CONSTRAINT [FK_Blog_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] (Id)
GO
ALTER TABLE [dbo].[Blog] ADD  CONSTRAINT [FK_Blog_UserDefinable] FOREIGN KEY([Id]) REFERENCES [dbo].[UserDefinable] ([Id])
GO

/* Product */
ALTER TABLE [dbo].[Product] ADD CONSTRAINT [FK_Product_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] (Id)
GO
ALTER TABLE [dbo].[Product] ADD  CONSTRAINT [FK_Product_UserDefinable] FOREIGN KEY([Id]) REFERENCES [dbo].[UserDefinable] ([Id])
GO

/* Menu Item */
ALTER TABLE [dbo].[MenuItem] ADD CONSTRAINT [FK_MenuItem_ParentMenuItem] FOREIGN KEY ([ParentMenuItemId]) REFERENCES [dbo].[MenuItem] (Id)
GO

/* Gallery */
ALTER TABLE [dbo].[Gallery] ADD CONSTRAINT [FK_Gallery_CoverPhoto] FOREIGN KEY ([CoverPhotoId]) REFERENCES [dbo].[Resource] (Id)
GO
ALTER TABLE [dbo].[Gallery] ADD  CONSTRAINT [FK_Gallery_UserDefinable_Inheritence] FOREIGN KEY([Id]) REFERENCES [dbo].[UserDefinable] ([Id])
GO
ALTER TABLE [dbo].[Gallery] ADD  CONSTRAINT [FK_Gallery_UserDefinable] FOREIGN KEY([Id]) REFERENCES [dbo].[UserDefinable] ([Id])
GO

/* Join_UserEvent */
ALTER TABLE [dbo].[Join_UserEvent] ADD CONSTRAINT [FK_Join_UserEvent_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] (Id) ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Join_UserEvent] ADD CONSTRAINT [FK_Join_UserEvent_Event] FOREIGN KEY ([EventId]) REFERENCES [dbo].[Event] (Id) ON DELETE CASCADE
GO

/* Entry */
ALTER TABLE [dbo].[Entry] ADD CONSTRAINT [FK_Entry_Event] FOREIGN KEY ([EventId]) REFERENCES [dbo].[Event] (Id)
GO

/* UserDefinable */
ALTER TABLE [dbo].[UserDefinable] ADD CONSTRAINT [FK_UserDefinable_User] FOREIGN KEY ([UserCreatorId]) REFERENCES [dbo].[User] (Id)
GO

/* Actuality */
ALTER TABLE [dbo].[Actuality] ADD CONSTRAINT [FK_Actuality_UserDefinable] FOREIGN KEY ([UserDefinableId]) REFERENCES [dbo].[UserDefinable] (Id)
GO

/* Link */
ALTER TABLE [dbo].[Link] ADD CONSTRAINT [FK_Link_Category] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] (Id)
GO