USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='DeleteClass')
	DROP PROCEDURE DeleteClass
GO

CREATE PROCEDURE DeleteClass

@ClassID INT

AS

BEGIN

	DELETE FROM 
		Classes
	WHERE
		ClassID = @ClassID

END
GO