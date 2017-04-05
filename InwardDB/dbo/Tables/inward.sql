CREATE TABLE [dbo].[inward] (
    [inward_no]      BIGINT          NOT NULL,
    [inward_date]    DATETIME        NULL,
    [bill_no]        VARCHAR (50)    NULL,
    [bill_type]      VARCHAR (50)    NULL,
    [bill_date]      DATE            NULL,
    [po_no]          VARCHAR (50)    NULL,
    [po_date]        DATE            NULL,
    [sup_name]       VARCHAR (100)   NULL,
    [material_type]  VARCHAR (50)    NULL,
    [Totla_amt]      DECIMAL (20, 2) NULL,
    [Inwardnumber]   BIGINT          NULL,
    [FinicialYearID] INT             NULL,
    CONSTRAINT [PK_inward] PRIMARY KEY CLUSTERED ([inward_no] ASC),
    CONSTRAINT [FK_inward_FinicialYears] FOREIGN KEY ([FinicialYearID]) REFERENCES [dbo].[FinicialYears] ([FinicialYearID])
);

