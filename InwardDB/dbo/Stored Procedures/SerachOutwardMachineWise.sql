CREATE PROCEDURE dbo.SerachOutwardMachineWise
	(
	      @mc varchar(30)=NULL,
		  @dt1 date=null,
		  @dt2 date=NULL,
		  @flag int=null
	)	
AS
if @flag=1
begin

   SELECT     Outward.IssueTo, Outward.IssueNo, Outward.Issuedate, Outward_Item.Material_name, Outward_Item.MachineName, Outward_Item.qty, 
                         Outward_Item.IssueQty
   FROM         Outward INNER JOIN
                         Outward_Item ON Outward.IssueNo = Outward_Item.IssueNo
   WHERE     Outward_Item.MachineName = @mc and Outward.Issuedate between @dt1 and @dt2 

end




RETURN