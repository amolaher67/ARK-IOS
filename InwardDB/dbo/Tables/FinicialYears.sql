CREATE TABLE [dbo].[FinicialYears] (
    [FinicialYearID] INT           IDENTITY (1, 1) NOT NULL,
    [FinicialYear]   NVARCHAR (50) NOT NULL,
    [isActive]       BIT           NULL,
    [FinYear]        INT           NOT NULL,
    CONSTRAINT [PK_FinicialYears] PRIMARY KEY CLUSTERED ([FinicialYearID] ASC)
);

