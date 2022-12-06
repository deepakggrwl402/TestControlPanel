CREATE TABLE [dbo].[TestCases] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [TestTitle]       NVARCHAR (MAX) NULL,
    [TestDate]        DATETIME2 (7)  NOT NULL,
    [TestDescription] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_TestCases] PRIMARY KEY CLUSTERED ([Id] ASC)
);

