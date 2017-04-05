CREATE PROCEDURE dbo.AddMaterialName
	
	(
	@MaterialName varchar(300) =NULL

	)
	
AS
insert into  partMaster values(@MaterialName)
	RETURN