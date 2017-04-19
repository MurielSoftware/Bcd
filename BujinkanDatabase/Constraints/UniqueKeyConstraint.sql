/* User */
ALTER TABLE [dbo].[User] ADD CONSTRAINT [UC_User_Email] UNIQUE ([Email])
GO

/* Role */
ALTER TABLE [dbo].[Role] ADD CONSTRAINT [UC_Role_Name] UNIQUE ([Name])
GO

/* Link */
ALTER TABLE [dbo].[Link] ADD CONSTRAINT [UC_Link_Name] UNIQUE ([Name])
GO

/*Vocabulary */
ALTER TABLE [dbo].[Vocabulary] ADD CONSTRAINT [UC_Vocabulary_Word] UNIQUE ([Word])
GO

/* BaseEvent */
ALTER TABLE [dbo].[Event] ADD CONSTRAINT [UC_Event_Theme] UNIQUE ([Theme])
GO

/* Blog */
ALTER TABLE [dbo].[Blog] ADD CONSTRAINT [UC_Blog_Name] UNIQUE ([Name])
GO

/* Dojo */
ALTER TABLE [dbo].[Dojo] ADD CONSTRAINT [UC_Dojo_Name] UNIQUE ([Name])
GO

/* Product */
ALTER TABLE [dbo].[Product] ADD CONSTRAINT [UC_Product_Name] UNIQUE ([Name])
GO