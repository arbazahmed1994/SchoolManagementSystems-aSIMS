USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='DeleteEmployeeAccount')
	DROP PROCEDURE DeleteEmployeeAccount
GO

CREATE PROCEDURE DeleteEmployeeAccount 

@UserID INT

AS

BEGIN

	UPDATE EmployeeAccount SET
		IsDeleted = 1
	WHERE
		UserID = @UserID

END