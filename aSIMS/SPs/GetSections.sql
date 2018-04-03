USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetSections')
	DROP PROCEDURE GetSections
GO

CREATE PROCEDURE GetSections

AS

BEGIN

	SELECT
		SectionID,
		SectionName,
		C.ClassName,
		T.TeacherName + ' - ' + GS.GroupSectionName AS TeacherName
	FROM
		Sections AS S
		INNER JOIN Classes AS C ON C.ClassID = S.SectionID
		INNER JOIN Teachers AS T ON T.TeacherID = S.TeacherID
		INNER JOIN GroupSection AS GS ON GS.GroupSectionID = T.GroupSectionID

END