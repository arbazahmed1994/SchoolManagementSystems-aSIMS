USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetEmployeeAccountByID')
	DROP PROCEDURE GetEmployeeAccountByID
GO

CREATE PROCEDURE GetEmployeeAccountByID

@UserID INT

AS

BEGIN

	SELECT
		 UserID,
		 UserCode,
		 UserName,
		 Password,
		 FullName,
		 EmailAddress,
		 Phone,
		 Mobile,
		 Address,
		 DateOfBirth,
		 CNIC,
		 RoleID,
		 GenderID,
		 CityID,
		 DesignationID,
		 UserTypeID,
		 IsDeleted,
		 EntryUser,
		 EntryDate,
		 UpdateUser,
		 UpdateDate
	FROM 
		EmployeeAccount
	WHERE
		UserID = @UserID AND
		IsDeleted = 0

END