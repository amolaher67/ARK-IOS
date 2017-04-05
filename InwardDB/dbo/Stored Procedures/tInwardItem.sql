CREATE PROCEDURE dbo.tInwardItem
	(
		@GrnNo varchar(20)=NULL,
		@MaterialName varchar(50)=NULL,
		@MaterialUnit varchar(30)=NULL,
		@Material_qty  int=NULL,
		@Material_rate decimal(20,2)=NULL,
		@Material_Amount decimal(20,2)=NULL,
		@Material_machine varchar(50)=NULL
	)
	 
   AS
	
	    

	   insert into material_inward_item values
	    (@GrnNo,
		@MaterialName,
		@Material_qty,
		@MaterialUnit,
		@Material_rate,
		@Material_Amount,
		@Material_machine)


  RETURN