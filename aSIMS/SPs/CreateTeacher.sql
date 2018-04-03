USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateTeacher')
	DROP PROCEDURE CreateTeacher
GO

CREATE PROCEDURE CreateTeacher

@TeacherName VARCHAR(50),
@DateOfBirth DATE,
@GenderID INT,
@Address NVARCHAR(100),
@Phone VARCHAR(20),
@Mobile VARCHAR(20),
@Email VARCHAR(50),
@UserName VARCHAR(25),
@Password VARCHAR(25),
@Qualification VARCHAR(50),
@CNIC VARCHAR(20),
@CityID INT,
@EntryUser INT,
@RoleID INT,
@DesignationID INT,
@GroupSectionID INT

AS

BEGIN
	
	INSERT INTO Teachers (
		TeacherName,
        DateOfBirth,
        GenderID,
        Address,
        Phone,
        Mobile,
        Email,
        UserName,
        Password,
        Qualification,
        CNIC,
        CityID,
        UserTypeID,
        IsDeleted,
        EntryUser,
        EntryDate,
        RoleID,
        DesignationID,
		GroupSectionID )
	VALUES (
		@TeacherName,
        @DateOfBirth,
        @GenderID,
        @Address,
        @Phone,
        @Mobile,
        @Email,
        @UserName,
        @Password,
        @Qualification,
        @CNIC,
        @CityID,
        1,
        0,
        @EntryUser,
        GETDATE(),
        @RoleID,
        @DesignationID,
		@GroupSectionID )

END