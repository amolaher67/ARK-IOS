CREATE PROCEDURE dbo.GetAccountInfo
(
    @str  varchar(30)=NULL ,
    @table_name  int
)

	
AS
declare @stk int =null;
begin
	
	if @table_name=1
	begin
	SELECT DISTINCT Material_Name AS material_name
	FROM         PartMaster
	WHERE     (Material_Name LIKE @str)
	
	end

if @table_name=2
		begin
		SELECT  distinct machine_name 
		FROM      material_inward_item
		WHERE    (machine_name LIKE @str)
	
end
if @table_name=3
		begin
		SELECT  distinct IssueTo  
		FROM    Outward
	
	
end

if @table_name=4
		begin
		SELECT  distinct unit_id   
		FROM  material_inward_item   
	
	end

	if @table_name=5
	begin

   
	SELECT       material_inward_item.material_name
FROM            material_inward_item  left outer  JOIN
                         Outward_Item ON material_inward_item.material_name = Outward_Item.Material_name
GROUP BY material_inward_item.material_name
having (SUM(material_inward_item.qty) - isnull(SUM(Outward_Item.IssueQty),0))>0

	
	end

	if @table_name=6
	begin
	SELECT DISTINCT material_inward_item.material_name
    FROM            material_inward_item
    WHERE      material_inward_item.material_name LIKE @str
	end




end