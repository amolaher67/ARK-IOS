CREATE TABLE [dbo].[Outward] (
    [IssueNo]   BIGINT       NOT NULL,
    [IssueTo]   VARCHAR (50) NULL,
    [Issuedate] DATE         NULL,
    CONSTRAINT [PK_Outward] PRIMARY KEY CLUSTERED ([IssueNo] ASC)
);

