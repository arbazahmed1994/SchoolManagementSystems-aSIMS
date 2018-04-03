USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetGroupSection')
	DROP PROCEDURE GetGroupSection
GO

CREATE PROCEDURE GetGroupSection

AS

BEGIN

	SELECT 
		GroupSectionID,
		GroupSectionName
	FROM
		GroupSection

END
GO