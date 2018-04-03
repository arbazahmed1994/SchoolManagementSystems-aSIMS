USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetDesignation')
	DROP PROCEDURE GetDesignation
GO

CREATE PROCEDURE GetDesignation

AS

BEGIN

	SELECT
		DesignationID,
		DesignationName
	FROM 
		Designation

END