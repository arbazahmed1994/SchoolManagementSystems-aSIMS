USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='UpdateClass')
	DROP PROCEDURE UpdateClass
GO

CREATE PROCEDURE UpdateClass

@ClassID INT,
@ClassName VARCHAR(30),
@ClassNumericName VARCHAR(20)

AS

BEGIN

	UPDATE Classes SET 
		ClassName = @ClassName,
		ClassNumericName = @ClassNumericName
	WHERE
		ClassID = @ClassID

END
GO