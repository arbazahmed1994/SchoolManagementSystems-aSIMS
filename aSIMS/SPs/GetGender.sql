USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetGender')
	DROP PROCEDURE GetGender
GO

CREATE PROCEDURE GetGender

AS

BEGIN

	SELECT
		GenderID,
		GenderName
	FROM 
		Gender

END