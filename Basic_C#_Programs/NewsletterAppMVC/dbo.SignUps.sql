CREATE TABLE [dbo].[SignUps] (
    [id]           INT           NOT NULL,
    [FirstName]    VARCHAR (30)  NULL,
    [LastName]     VARCHAR (30)  NULL,
    [EmailAddress] VARCHAR (100) NULL,
    [SocialSecurityNumber] VARCHAR(15) NULL, 
    CONSTRAINT [PK_SignUps] PRIMARY KEY CLUSTERED ([id] ASC)
);

