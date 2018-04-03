USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='DeleteParent')
	DROP PROCEDURE DeleteParent
GO

CREATE PROCEDURE DeleteParent

@ParentID INT 

AS

BEGIN

	UPDATE Parents SET 
		IsDeleted = 1
	WHERE
		ParentID = @ParentID

END