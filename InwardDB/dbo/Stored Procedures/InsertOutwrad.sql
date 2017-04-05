CREATE PROCEDURE dbo.InsertOutwrad
	(
	   @IssueNo int = 5,
	   @IssueTo varchar(40),
	   @IssueDate date
	)
	
AS
	
	  insert into outward Values(@IssueNo,@IssueTo,@IssueDate)



	RETURN