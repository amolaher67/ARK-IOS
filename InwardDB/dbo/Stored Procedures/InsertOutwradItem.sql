CREATE PROCEDURE dbo.InsertOutwradItem
	(
    	@IssueId  int=null ,
	    @Material varchar(50)=null,
		@Machine varchar(50)=null,
		
		@qty decimal(18,0)=NULL,
		@IssueQty decimal(18,0)=null
	)
	
AS
	
	 insert into outward_item values(@IssueId,@Material,@Machine,@qty,@IssueQty)

	RETURN