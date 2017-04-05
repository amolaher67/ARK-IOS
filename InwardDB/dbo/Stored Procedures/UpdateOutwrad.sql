CREATE PROCEDURE dbo.UpdateOutwrad
	(
	   @IssueNo int = 5,
	   @IssueTo varchar(40),
	   @IssueDate date
	)
	
AS
	
	 Update Outward set Issueno=@IssueNo,issueto=@IssueTo, issuedate=@IssueDate



	RETURN