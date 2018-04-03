USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetFullTeacherName')
	DROP PROCEDURE GetFullTeacherName
GO

CREATE PROCEDURE GetFullTeacherName

AS

BEGIN
	
	SELECT
		TeacherID,
		TeacherName + ' - ' + GS.GroupSectionName AS TeacherName
	FROM
		Teachers AS T
		INNER JOIN GroupSection AS GS ON GS.GroupSectionID = T.GroupSectionID

END
GO