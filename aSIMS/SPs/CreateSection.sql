USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateSection')
	DROP PROCEDURE CreateSection
GO

CREATE PROCEDURE CreateSection

@SectionName VARCHAR(30),
@ClassID INT,
@TeacherID INT

AS

BEGIN

	INSERT INTO Sections ( 
		SectionName,
		ClassID,
		TeacherID )
	VALUES (
		@SectionName,
		@ClassID,
		@TeacherID )

END
GO