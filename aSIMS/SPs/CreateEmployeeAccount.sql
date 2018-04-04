USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateEmployeeAccount')
	DROP PROCEDURE CreateEmployeeAccount
GO

CREATE PROCEDURE CreateEmployeeAccount

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

	IF EXISTS(SELECT UserID FROM EmployeeAccount WHERE UserName = @UserName)
	BEGIN
		RAISERROR('Username already exist. Try different one', 16, 1)
		RETURN
	END

	IF EXISTS(SELECT UserID FROM EmployeeAccount WHERE EmailAddress = @EmailAddress)
	BEGIN
		RAISERROR('Email already exist. Use personel Authentic Email Address', 16, 1)
		RETURN
	END

	INSERT INTO EmployeeAccount (
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
		EntryDate )
	VALUES (
		(SELECT (CONVERT(VARCHAR,YEAR(GETDATE())) + '-' + RIGHT('0000' + CONVERT(VARCHAR,ISNULL(MAX(UserID),0)+1),4)) FROM EmployeeAccount),
		@UserName,
		@Password,
		@FullName,
		@EmailAddress,
		@Phone,
		@Mobile,
		@Address,
		@DateOfBirth,
		@CNIC,
		@RoleID,
		@GenderID,
		@CityID,
		@DesignationID,
		2,
		0,
		@EntryUser,
		GETDATE() 
	)

END