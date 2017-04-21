/* Training */
CREATE NONCLUSTERED INDEX [IX_Training_UserId] ON [dbo].[Training] ([UserId])
GO
CREATE NONCLUSTERED INDEX [IX_Training_CountryId] ON [dbo].[Training] ([CountryId])
GO

/* User */
CREATE NONCLUSTERED INDEX [IX_User_CountryId] ON [dbo].[User] ([CountryId])
GO
CREATE NONCLUSTERED INDEX [IX_User_DojoId] ON [dbo].[User] ([DojoId])
GO
CREATE NONCLUSTERED INDEX [IX_User_RoleId] ON [dbo].[User] ([RoleId])
GO

/* BaseEvent */
CREATE NONCLUSTERED INDEX [IX_User_CountryId] ON [dbo].[Event] ([CountryId])
GO

/* Blog */
CREATE NONCLUSTERED INDEX [IX_Blog_UserId] ON [dbo].[Blog] ([UserId])
GO
CREATE NONCLUSTERED INDEX [IX_Blog_CategoryId] ON [dbo].[Blog] ([CategoryId])
GO

/* Product */
CREATE NONCLUSTERED INDEX [IX_Product_CategoryId] ON [dbo].[Product] ([CategoryId])
GO

/* MenuItem */
CREATE NONCLUSTERED INDEX [IX_MenuItem_ParentMenuItem] ON [dbo].[MenuItem] ([ParentMenuItemId])
GO

/* Gallery */
CREATE NONCLUSTERED INDEX [IX_Gallery_CoverPhoto] ON [dbo].[Gallery] ([CoverPhotoId])
GO

/* Join_UserEvent */
CREATE NONCLUSTERED INDEX [IX_Join_UserEvent_Event] ON [dbo].[Join_UserEvent] ([EventId])
GO
CREATE NONCLUSTERED INDEX [IX_Join_UserEvent_User] ON [dbo].[Join_UserEvent] ([UserId])
GO

/* Entry */
CREATE NONCLUSTERED INDEX [IX_Entry_Event] ON [dbo].[Entry] ([EventId])
GO

/* UsrDefinable */
CREATE NONCLUSTERED INDEX [IX_UserDefinable_User] ON [dbo].[UserDefinable] ([UserCreatorId])
GO

/* Link */
CREATE NONCLUSTERED INDEX [IX_Link_CategoryId] ON [dbo].[Link] ([CategoryId])
GO