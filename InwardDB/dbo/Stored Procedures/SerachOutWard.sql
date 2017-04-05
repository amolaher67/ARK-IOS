CREATE PROCEDURE dbo.SerachOutWard
	(
	@dt1 date=NULL,
	@dt2 date=NULL
	)
	
AS
	
	  SELECT        Outward.IssueNo, Outward.IssueTo, Outward.Issuedate, Outward_Item.Material_name, Outward_Item.MachineName, Outward_Item.qty, Outward_Item.IssueQty,
	                               (SELECT        sum(rate*qty)/sum(qty) 
	                                 FROM            material_inward_item
	                                 GROUP BY material_name
	                                 HAVING         (material_name = Outward_Item.Material_name)) AS rate
	  FROM            Outward INNER JOIN
	                           Outward_Item ON Outward.IssueNo = Outward_Item.IssueNo
	  WHERE        (Outward.Issuedate BETWEEN @dt1 AND @dt2)
	

		RETURN