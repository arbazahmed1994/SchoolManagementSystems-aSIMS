USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='DeleteTeacher')
	DROP PROCEDURE DeleteTeacher
GO

CREATE PROCEDURE DeleteTeacher

@TeacherID INT 

AS

BEGIN

	UPDATE Teachers SET 
		IsDeleted = 1
	WHERE
		TeacherID = @TeacherID

END