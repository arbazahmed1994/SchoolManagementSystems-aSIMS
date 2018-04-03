USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetEmployeeAccount')
	DROP PROCEDURE GetEmployeeAccount
GO

CREATE PROCEDURE GetEmployeeAccount

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
		 AR.RoleName,
		 G.GenderName,
		 C.CityName,
		 D.DesignationName,
		 EA.UserTypeID,
		 IsDeleted,
		 EntryUser,
		 EntryDate,
		 UpdateUser,
		 UpdateDate
	FROM 
		EmployeeAccount AS EA
		INNER JOIN Designation AS D ON D.DesignationID = EA.DesignationID
		INNER JOIN Gender AS G ON G.GenderID = EA.GenderID
		INNER JOIN AccountRole AS AR ON AR.RoleID = EA.RoleID
		INNER JOIN City AS C ON C.CityID = EA.CityID
	WHERE
		EA.IsDeleted = 0

END