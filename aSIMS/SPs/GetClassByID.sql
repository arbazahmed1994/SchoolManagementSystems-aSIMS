USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetClassByID')
	DROP PROCEDURE GetClassByID
GO

CREATE PROCEDURE GetClassByID

@ClassID INT

AS

BEGIN

	SELECT
		ClassID,
		ClassName,
		ClassNumericName
	FROM 
		Classes
	WHERE
		ClassID = @ClassID

END
GO