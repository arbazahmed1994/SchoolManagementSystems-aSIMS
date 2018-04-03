USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetAdminRoles')
	DROP PROCEDURE GetAdminRoles
GO

CREATE PROCEDURE GetAdminRoles

AS

BEGIN

	SELECT
		RoleID,
		RoleName
	FROM 
		AccountRole
	WHERE
		UserTypeID = 2

END