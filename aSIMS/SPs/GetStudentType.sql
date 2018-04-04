USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetStudentType')
	DROP PROCEDURE GetStudentType
GO

CREATE PROCEDURE GetStudentType

AS

BEGIN

	SELECT
		StudentTypeID,
		StudentTypeName
	FROM 
		StudentType

END