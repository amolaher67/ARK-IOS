CREATE TABLE [dbo].[material_inward_item] (
    [inward_no]     BIGINT          NOT NULL,
    [material_name] VARCHAR (250)   NULL,
    [qty]           DECIMAL (18, 2) NULL,
    [unit_id]       VARCHAR (50)    NULL,
    [rate]          DECIMAL (18, 2) NULL,
    [total]         DECIMAL (18, 2) NULL,
    [machine_name]  VARCHAR (250)   NULL
);

