-- =============================================
-- Author:		<Amol Aher>
-- Create date: <04 April 2017>
-- Description:	<Fin Year>
-- =============================================

CREATE PROCEDURE InsertOrUpdate_FinicialYear 
	-- Add the parameters for the stored procedure here
	 @IsActive bit=0,
	 @FinicialYearID INT=0
AS

DECLARE @MaxYear INT =NULL
DECLARE @InitialMaxYear INT ='2017'
DECLARE @FinicialYear varchar(50) =''

BEGIN
	
	SET NOCOUNT ON;

	IF @IsActive = 0 
	BEGIN
	     SET @MaxYear=(SELECT MAX(FinYear) FROM FinicialYears)

	     IF ISNULL(@MaxYear,0)=0
		 BEGIN 
		    INSERT INTO FinicialYears VALUES ('1 Apr 2017 to 31 Mar 2018', 1 ,@InitialMaxYear )
		 END
		 ELSE
		BEGIN  
		   
		    SET @FinicialYear='1 Apr '+ CONVERT(VARCHAR(10),(@MaxYear+1)) +' to 31 Mar '+ CONVERT(VARCHAR(10),(@MaxYear+2))
		    INSERT INTO FinicialYears VALUES (@FinicialYear, 0, @MaxYear + 1)
		END

	END 
	ELSE IF @IsActive = 1 AND @FinicialYearID <> 0
	BEGIN
			UPDATE FinicialYears
			SET isActive = 0
			WHERE isActive = 1

			UPDATE FinicialYears
			SET isActive = 1
			WHERE FinicialYearID = @FinicialYearID


	END
END