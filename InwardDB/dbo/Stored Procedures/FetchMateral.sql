CREATE PROCEDURE dbo.FetchMateral
(
    @str  varchar(30)=NULL
   
)

	
AS
begin
	
	                    SELECT material_inward_item.material_name, material_inward_item.machine_name
                          FROM         inward INNER JOIN
                        material_inward_item ON inward.inward_no = material_inward_item.inward_no
                        WHERE     (material_inward_item.machine_name = 'STORE'and material_inward_item.material_name like @str)
	
	end