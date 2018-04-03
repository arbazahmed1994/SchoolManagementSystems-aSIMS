USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='UpdateSection')
	DROP PROCEDURE UpdateSection
GO

CREATE PROCEDURE UpdateSection

@SectionID INT,
@SectionName VARCHAR(30),
@ClassID INT,
@TeacherID INT

AS

BEGIN

	UPDATE Sections SET 
		SectionName = @SectionName,
		ClassID = @ClassID,
		TeacherID = @TeacherID
	WHERE
		SectionID = @SectionID

END
GO