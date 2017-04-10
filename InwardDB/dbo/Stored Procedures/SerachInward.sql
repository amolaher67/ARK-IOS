CREATE PROCEDURE [dbo].[SerachInward]
	(
	@dt1 date=NULL,
	@dt2 date=NULL,
	@flag int=NUll,
	@mc varchar(200)=Null
	)
	
AS
	   if(@flag=0)
	   begin

	  SELECT     inward_no, FinicialYears.FinicialYear , inward_date,Inwardnumber, bill_no, bill_type, bill_date, po_no, po_date, sup_name, material_type
	  FROM        inward INNER JOIN FinicialYears ON inward.FinicialYearID=FinicialYears.FinicialYearID
	  WHERE     (inward_date BETWEEN @dt1 AND @dt2)
	end

	if(@flag=1)
	begin

	SELECT     inward.inward_no,inward.Inwardnumber, FinicialYears.FinicialYear, inward.inward_date, inward.bill_no, inward.bill_type, inward.bill_date, inward.po_no, inward.po_date, inward.sup_name, 
	                      inward.material_type, material_inward_item.material_name, material_inward_item.qty, material_inward_item.unit_id, material_inward_item.rate, 
	                      material_inward_item.total, material_inward_item.machine_name
	FROM inward 
	INNER JOIN material_inward_item ON inward.inward_no = material_inward_item.inward_no
	INNER JOIN FinicialYears ON inward.FinicialYearID=FinicialYears.FinicialYearID
	WHERE     (inward.inward_date BETWEEN @dt1 AND @dt2)
	ORDER BY inward.inward_no
	end


	if(@flag=2)
	begin

	 SELECT     inward.inward_no, inward.inward_date,FinicialYears.FinicialYear,inward.Inwardnumber, inward.bill_no, inward.bill_type, inward.bill_date, inward.po_no, inward.po_date, inward.sup_name, 
                      inward.material_type,  material_inward_item.material_name, material_inward_item.qty, 
                      material_inward_item.unit_id, material_inward_item.rate, material_inward_item.total, material_inward_item.machine_name
FROM         inward INNER JOIN
                      material_inward_item ON inward.inward_no = material_inward_item.inward_no
					  INNER JOIN FinicialYears ON inward.FinicialYearID=FinicialYears.FinicialYearID
WHERE     (material_inward_item.machine_name =@mc and inward.inward_date BETWEEN @dt1 AND @dt2)

	end

	if(@flag=3)
	begin

	 SELECT     inward_no, FinicialYears.FinicialYear,inward_date,inward.Inwardnumber, bill_no, bill_type, bill_date, po_no, po_date, sup_name, material_type
	  FROM         inward
	  INNER JOIN FinicialYears ON inward.FinicialYearID=FinicialYears.FinicialYearID
	  WHERE     (inward_date BETWEEN @dt1 AND @dt2) and inward.bill_type =@mc

	end

	if(@flag=4)
	begin

	 SELECT     inward.inward_no,FinicialYears.FinicialYear, inward.inward_date,inward.Inwardnumber, inward.bill_no, inward.bill_type, inward.bill_date, inward.po_no, inward.po_date, inward.sup_name, 
                      inward.material_type,  material_inward_item.material_name, material_inward_item.qty, 
                      material_inward_item.unit_id, material_inward_item.rate, material_inward_item.total, material_inward_item.machine_name
FROM         inward INNER JOIN
                      material_inward_item ON inward.inward_no = material_inward_item.inward_no
					  INNER JOIN FinicialYears ON inward.FinicialYearID=FinicialYears.FinicialYearID
WHERE    (inward_date BETWEEN @dt1 AND @dt2) and inward.bill_type =@mc


	end
	if(@flag=5)
	begin
	 SELECT  inward_no,inward.Inwardnumber,FinicialYears.FinicialYear, inward_date, bill_no, bill_type, bill_date, po_no, po_date, sup_name, material_type
	 FROM   inward
	 INNER JOIN FinicialYears ON inward.FinicialYearID=FinicialYears.FinicialYearID
	 WHERE (inward_date BETWEEN @dt1 AND @dt2) AND inward_no in(SELECT  distinct mItem.inward_no from material_inward_item mItem where machine_name=@mc )
	 

end




		RETURN