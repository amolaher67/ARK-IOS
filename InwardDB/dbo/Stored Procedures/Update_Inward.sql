CREATE PROCEDURE dbo.Update_Inward
(	
   @grn_no bigint=NULL,
   @inward_date date=NULL,
   @sup varchar(40)=NULL,
   @bill_no VARCHAR(40)=NULL,
   @billdate date=NULL,
   @billtype varchar(40)=NULL,
   @material_type varchar(40)=NULL,
   @pono varchar(30)=NULL,
   @podate varchar(40)=NULL,
   @Total decimal(20,2)=NULL
 )
	
AS
	/* SET NOCOUNT ON */
	
	 update inward set
	                    inward_date=@inward_date,
						bill_no=@bill_no,
						bill_type=@billtype,
						bill_date=@billdate,
						po_no=@pono,
						po_date=@podate,
						sup_name=@sup,
						material_type=@material_type,
						Totla_amt=@Total 
						where inward_no=@grn_no
	
	
	RETURN