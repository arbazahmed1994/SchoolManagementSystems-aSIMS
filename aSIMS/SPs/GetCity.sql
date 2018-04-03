USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetCity')
	DROP PROCEDURE GetCity
GO

CREATE PROCEDURE GetCity

AS

BEGIN

	SELECT
		CityID,
		CityName
	FROM 
		City

END