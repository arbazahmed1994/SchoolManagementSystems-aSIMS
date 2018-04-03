USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='LoginAuthentication')
	DROP PROCEDURE LoginAuthentication
GO

CREATE PROCEDURE LoginAuthentication

@Username VARCHAR(25),
@Password VARCHAR(25),
@UserTypeID INT

AS

BEGIN

		IF(@UserTypeID = 2)
		BEGIN
			IF EXISTS (SELECT UserID FROM EmployeeAccount WHERE UserName = @Username AND Password = @Password)
			BEGIN
				SELECT 
					UserID,
					RoleID,
					FullName,
					D.DesignationName AS Designation
				FROM
					EmployeeAccount AS EA
					INNER JOIN Designation AS D ON D.DesignationID = EA.DesignationID
				WHERE
					EA.UserName = @Username AND
					EA.Password = @Password
			END
			ELSE
			BEGIN
				RAISERROR('Username or Password is Incorrect', 16, 1)
				RETURN
			END
		END
	
		IF(@UserTypeID = 1)
		BEGIN
			IF EXISTS (SELECT TeacherID FROM Teachers WHERE UserName = @Username AND Password = @Password)
			BEGIN
				SELECT 
					TeacherID AS UserID,
					RoleID,
					TeacherName AS FullName,
					D.DesignationName AS Designation
				FROM
					Teachers AS T
					INNER JOIN Designation AS D ON D.DesignationID = T.DesignationID
				WHERE
					T.UserName = @Username AND
					T.Password = @Password
			END
			ELSE
			BEGIN
				RAISERROR('Username or Password is Incorrect', 16, 1)
				RETURN
			END
		END

END