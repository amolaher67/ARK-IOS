CREATE PROCEDURE dbo.DeleteInward
(	
   @GrnNO BIgint =Null
)
	AS
	
	/* SET NOCOUNT ON */
	
	  delete from Inward Where Inward_no=@GrnNo


	RETURN