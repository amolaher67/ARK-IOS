
CREATE PROCEDURE [dbo].[Insert_Inward]
(	
   @grn_no bigint OUTPUT,
   @inward_date DateTime=NULL,
   @sup varchar(40)=NULL,
   @bill_no varchar(40)=NULL,
   @billdate DateTime=NULL,
   @billtype varchar(40)=NULL,
   @material_type varchar(40)=NULL,
   @pono varchar(30)=NULL,
   @podate DateTime=NULL,
   @Total decimal(20,2)=NULL,
   @inwardNumber varchar(50),
   @finicialYearID INT
 )
	
AS
BEGIN
	/* SET NOCOUNT ON */
	
	--Find Max Grn no and insert that number
	SET @grn_no=(SELECT CASE WHEN ISNULL(MAX(inward_no),0)=0 THEN 1 ELSE MAX(inward_no)+1 END  FROM inward)

	INSERT INTO [dbo].[inward]
           ([inward_no]
           ,[bill_no]
           ,[inward_date]
           ,[Inwardnumber]
           ,[bill_type]
           ,[bill_date]
           ,[po_no]
           ,[po_date]
           ,[sup_name]
           ,[material_type]
           ,[Totla_amt]
           ,[FinicialYearID])
     VALUES
           (  @grn_no,
              @bill_no,
              @inward_date,
              @inwardNumber,
              @billtype,
              @billdate,
              @pono,
              @podate,
			  @sup,
			  @material_type,
			  @Total,
              @finicialYearID)

   
END