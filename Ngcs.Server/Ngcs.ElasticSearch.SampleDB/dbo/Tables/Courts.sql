CREATE TABLE [dbo].[Courts] (
    [id]    INT           NOT NULL,
    [name]  NVARCHAR (50) NOT NULL,
    [level] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Courts] PRIMARY KEY CLUSTERED ([id] ASC)
);