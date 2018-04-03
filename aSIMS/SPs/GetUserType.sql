USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetUserType')
	DROP PROCEDURE GetUserType
GO

CREATE PROCEDURE GetUserType

AS

BEGIN

	SELECT
		UserTypeID,
		UserTypeName
	FROM 
		UserType

END