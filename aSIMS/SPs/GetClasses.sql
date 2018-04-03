USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetClasses')
	DROP PROCEDURE GetClasses
GO

CREATE PROCEDURE GetClasses

AS

BEGIN

	SELECT
		ClassID,
		ClassName,
		ClassNumericName
	FROM 
		Classes

END
GO