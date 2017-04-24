/* Training */
CREATE NONCLUSTERED INDEX [IX_Training_UserId] ON [dbo].[TRAINING] ([UserId])
GO
CREATE NONCLUSTERED INDEX [IX_Training_CountryId] ON [dbo].[TRAINING] ([CountryId])
GO

/* User */
CREATE NONCLUSTERED INDEX [IX_User_CountryId] ON [dbo].[USER] ([CountryId])
GO
CREATE NONCLUSTERED INDEX [IX_User_DojoId] ON [dbo].[USER] ([DojoId])
GO
CREATE NONCLUSTERED INDEX [IX_User_RoleId] ON [dbo].[USER] ([RoleId])
GO

/* BaseEvent */
CREATE NONCLUSTERED INDEX [IX_User_CountryId] ON [dbo].[EVENT] ([CountryId])
GO

/* Blog */
CREATE NONCLUSTERED INDEX [IX_Blog_UserId] ON [dbo].[BLOG] ([UserId])
GO
CREATE NONCLUSTERED INDEX [IX_Blog_CategoryId] ON [dbo].[BLOG] ([CategoryId])
GO

/* Product */
CREATE NONCLUSTERED INDEX [IX_Product_CategoryId] ON [dbo].[PRODUCT] ([CategoryId])
GO

/* MenuItem */
CREATE NONCLUSTERED INDEX [IX_MenuItem_ParentMenuItem] ON [dbo].[MENU_ITEM] ([ParentMenuItemId])
GO
CREATE NONCLUSTERED INDEX [IX_MenuItem_UserDefinable] ON [dbo].[MENU_ITEM] ([UserDefinableId])
GO

/* Gallery */
CREATE NONCLUSTERED INDEX [IX_Gallery_CoverPhoto] ON [dbo].[GALLERY] ([CoverPhotoId])
GO

/* Join_UserEvent */
CREATE NONCLUSTERED INDEX [IX_Join_UserEvent_Event] ON [dbo].[JOIN_USER_EVENT] ([EventId])
GO
CREATE NONCLUSTERED INDEX [IX_Join_UserEvent_User] ON [dbo].[JOIN_USER_EVENT] ([UserId])
GO

/* Entry */
CREATE NONCLUSTERED INDEX [IX_Entry_Event] ON [dbo].[ENTRY] ([EventId])
GO

/* UsrDefinable */
CREATE NONCLUSTERED INDEX [IX_UserDefinable_User] ON [dbo].[USER_DEFINABLE] ([UserCreatorId])
GO

/* Link */
CREATE NONCLUSTERED INDEX [IX_Link_CategoryId] ON [dbo].[LINK] ([CategoryId])
GO