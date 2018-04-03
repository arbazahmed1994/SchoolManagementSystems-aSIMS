USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='UpdateEmployeeAccount')
	DROP PROCEDURE UpdateEmployeeAccount
GO

CREATE PROCEDURE UpdateEmployeeAccount

@UserID INT,
@UserName VARCHAR(25),
@Password NVARCHAR(200),
@FullName VARCHAR(50),
@EmailAddress VARCHAR(100),
@Phone VARCHAR(20),
@Mobile VARCHAR(20),
@Address NVARCHAR(100),
@DateOfBirth DATE,
@CNIC VARCHAR(20),
@RoleID INT,
@GenderID INT,
@CityID INT,
@DesignationID INT,
@EntryUser INT

AS

BEGIN

	IF EXISTS(SELECT UserID FROM EmployeeAccount WHERE UserName = @UserName AND UserID != @UserID)
	BEGIN
		RAISERROR('Username already exist. Try different one', 16, 1)
		RETURN
	END

	IF EXISTS(SELECT UserID FROM EmployeeAccount WHERE EmailAddress = @EmailAddress AND UserID != @UserID)
	BEGIN
		RAISERROR('Email already exist. Use personel Authentic Email Address', 16, 1)
		RETURN
	END

	UPDATE EmployeeAccount SET
		UserName = @UserName,
		Password = @Password,
		FullName = @FullName,
		EmailAddress = @EmailAddress,
		Phone = @Phone,
		Mobile = @Mobile,
		Address = @Address,
		DateOfBirth = @DateOfBirth,
		CNIC = @CNIC,
		RoleID = @RoleID,
		GenderID = @GenderID,
		CityID = @CityID,
		DesignationID = @DesignationID,
		UpdateUser = @EntryUser,
		UpdateDate = GETDATE()
	WHERE 
		UserID = @UserID

	
END