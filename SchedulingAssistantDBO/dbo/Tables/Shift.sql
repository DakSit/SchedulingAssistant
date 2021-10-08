CREATE TABLE [dbo].[Shift] (
    [Id]         INT           NOT NULL,
    [Shift_Name] NVARCHAR (50) NOT NULL,
    [Day]        NVARCHAR (50) NOT NULL,
    [Start_Hour] NVARCHAR (50) NOT NULL,
    [End_Hour]   NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Shift] PRIMARY KEY CLUSTERED ([Id] ASC)
);

