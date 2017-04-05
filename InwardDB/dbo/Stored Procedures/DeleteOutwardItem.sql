CREATE PROCEDURE dbo.DeleteOutwardItem
		(
	         @OutNo int =NULL
	     ) 
	 
AS
	
	 delete from  outward_item where issueno=@OutNo
	
RETURN