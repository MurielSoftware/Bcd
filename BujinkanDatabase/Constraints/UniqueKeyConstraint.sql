/* User */
ALTER TABLE [dbo].[USER] ADD CONSTRAINT [UC_User_Email] UNIQUE ([Email])
GO

/* Role */
ALTER TABLE [dbo].[ROLE] ADD CONSTRAINT [UC_Role_Name] UNIQUE ([Name])
GO

/* Link */
ALTER TABLE [dbo].[LINK] ADD CONSTRAINT [UC_Link_Name] UNIQUE ([Name])
GO

/*Vocabulary */
ALTER TABLE [dbo].[VOCABULARY] ADD CONSTRAINT [UC_Vocabulary_Word] UNIQUE ([Word])
GO

/* BaseEvent */
ALTER TABLE [dbo].[EVENT] ADD CONSTRAINT [UC_Event_Theme] UNIQUE ([Theme])
GO

/* Blog */
ALTER TABLE [dbo].[BLOG] ADD CONSTRAINT [UC_Blog_Name] UNIQUE ([Name])
GO

/* Dojo */
ALTER TABLE [dbo].[DOJO] ADD CONSTRAINT [UC_Dojo_Name] UNIQUE ([Name])
GO

/* Product */
ALTER TABLE [dbo].[PRODUCT] ADD CONSTRAINT [UC_Product_Name] UNIQUE ([Name])
GO