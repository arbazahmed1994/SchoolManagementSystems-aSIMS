USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetSectionByID')
	DROP PROCEDURE GetSectionByID
GO

CREATE PROCEDURE GetSectionByID

@SectionID INT

AS

BEGIN

	SELECT
		SectionID,
		SectionName,
		ClassID,
		TeacherID
	FROM
		Sections
	WHERE
		SectionID = @SectionID

END