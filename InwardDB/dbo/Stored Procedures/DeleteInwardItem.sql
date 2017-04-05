CREATE PROCEDURE dbo.DeleteInwardItem
		(
	         @GrnNo int =NULL
	     ) 
	 
AS
	
	 delete from material_inward_item where inward_no=@GrnNo
	
RETURN