USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='UpdateTeacher')
	DROP PROCEDURE UpdateTeacher
GO

CREATE PROCEDURE UpdateTeacher

@TeacherID INT,
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
	
	UPDATE Teachers SET
		TeacherName = @TeacherName,
        DateOfBirth = @DateOfBirth,
        GenderID = @GenderID,
        Address = @Address,
        Phone = @Phone,
        Mobile = @Mobile,
        Email = @Email,
        UserName = @UserName,
        Password = @Password,
        Qualification = @Qualification,
        CNIC = @CNIC,
        CityID = @CityID,
        UserTypeID = 1,
        IsDeleted = 0,
        UpdateUser = @EntryUser,
        UpdateDate = GETDATE(),
        RoleID = @RoleID,
        DesignationID = @DesignationID,
		GroupSectionID = @GroupSectionID
	WHERE
		TeacherID = @TeacherID

END