CREATE PROCEDURE dbo.DeleteOutward
(	
   @OutNo BIgint =Null
)
	AS
	
	/* SET NOCOUNT ON */
	
	  delete from Outward Where Issueno=@OutNo


	RETURN