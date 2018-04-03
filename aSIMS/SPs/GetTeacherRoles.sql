USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetTeacherRoles')
	DROP PROCEDURE GetTeacherRoles
GO

CREATE PROCEDURE GetTeacherRoles

AS

BEGIN

	SELECT
		RoleID,
		RoleName
	FROM 
		AccountRole
	WHERE
		UserTypeID = 1

END