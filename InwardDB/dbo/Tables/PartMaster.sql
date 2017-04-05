CREATE TABLE [dbo].[PartMaster] (
    [Material_Name] VARCHAR (250) NULL,
    CONSTRAINT [IX_PartMaster] UNIQUE NONCLUSTERED ([Material_Name] ASC)
);

