CREATE TABLE [dbo].[Outward_Item] (
    [IssueNo]       BIGINT       NULL,
    [Material_name] VARCHAR (50) NULL,
    [MachineName]   VARCHAR (50) NULL,
    [qty]           DECIMAL (18) NULL,
    [IssueQty]      DECIMAL (18) NULL,
    CONSTRAINT [FK_Outward_Item_Outward] FOREIGN KEY ([IssueNo]) REFERENCES [dbo].[Outward] ([IssueNo])
);

