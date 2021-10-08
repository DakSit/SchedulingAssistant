CREATE TABLE [dbo].[User] (
    [ID]           INT          NOT NULL,
    [Username]     VARCHAR (50) NOT NULL,
    [First_Name]   VARCHAR (50) NOT NULL,
    [Last_Name]    VARCHAR (50) NOT NULL,
    [Password]     VARCHAR (50) NOT NULL,
    [Email]        VARCHAR (50) NULL,
    [Phone_Number] VARCHAR (50) NULL,
    [IsActive]     BIT          NULL,
    [Availability] INT          NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([ID] ASC)
);

