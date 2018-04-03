USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='DeleteSection')
	DROP PROCEDURE DeleteSection
GO

CREATE PROCEDURE DeleteSection

@SectionID INT

AS

BEGIN

	DELETE FROM 
		Sections
	WHERE
		SectionID = @SectionID

END
GO