
CREATE PROCEDURE [dbo].[Stock]
	(
	   @material_name varchar(50)=NULL,
	   @flag int=NULL
	   
	)
	
AS
   if @flag=0
   begin

             SELECT     material_inward_item.material_name, AVG(material_inward_item.rate) AS rate, SUM(material_inward_item.total) AS totaL, SUM(material_inward_item.qty) 
             - ISNULL(SUM(Outward_Item.IssueQty), 0) AS AvailableStock, inward.material_type
             FROM material_inward_item INNER JOIN
             inward ON material_inward_item.inward_no = inward.inward_no LEFT OUTER JOIN
             Outward_Item ON material_inward_item.material_name = Outward_Item.Material_name
             WHERE(inward.bill_type <> 'Labour' and  material_inward_item.machine_name='STORE')
             GROUP BY material_inward_item.material_name, inward.material_type
	 
	
	end


	if @flag=1
	begin

             SELECT     material_inward_item.material_name, AVG(material_inward_item.rate) AS rate, SUM(material_inward_item.total) AS totaL, SUM(material_inward_item.qty) 
             - ISNULL(SUM(Outward_Item.IssueQty), 0) AS AvailableStock, inward.material_type
             FROM material_inward_item INNER JOIN
             inward ON material_inward_item.inward_no = inward.inward_no LEFT OUTER JOIN
             Outward_Item ON material_inward_item.material_name = Outward_Item.Material_name
             WHERE(inward.bill_type <> 'Labour') and (material_inward_item.material_name = @material_name) and (material_inward_item.machine_name='STORE')
             GROUP BY material_inward_item.material_name, inward.material_type
	
	end
	
if @flag=2
	begin

	         SELECT     inward.material_type as material_name, AVG(material_inward_item.rate) AS rate, SUM(material_inward_item.total) AS totaL, SUM(material_inward_item.qty) 
             - ISNULL(SUM(Outward_Item.IssueQty), 0) AS AvailableStock
             FROM material_inward_item INNER JOIN
             inward ON material_inward_item.inward_no = inward.inward_no LEFT OUTER JOIN
             Outward_Item ON material_inward_item.material_name = Outward_Item.Material_name
             WHERE(inward.bill_type <> 'Labour' and material_inward_item.machine_name='STORE')
             GROUP BY inward.material_type

	end
	
	
	

	
	
	
	return