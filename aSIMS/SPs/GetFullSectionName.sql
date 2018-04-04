USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetFullSectionName')
	DROP PROCEDURE GetFullSectionName
GO

CREATE PROCEDURE GetFullSectionName

AS

BEGIN

	SELECT
		SectionID,
		C.ClassName + ' - ' + SectionName AS SectionName
	FROM
		Sections AS S
		INNER JOIN Classes AS C ON C.ClassID = S.SectionID

END