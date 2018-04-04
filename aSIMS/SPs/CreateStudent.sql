USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateStudent')
	DROP PROCEDURE CreateStudent
GO

CREATE PROCEDURE CreateStudent

@StudentName VARCHAR(50),
@RollNumber VARCHAR(10),
@ParentID INT,
@SectionID INT,
@DateOfBirth DATE,
@GenderID INT,
@Address VARCHAR(200),
@Phone VARCHAR(50),
@Email VARCHAR(50),
@TransportID INT,
@Photo VARCHAR(max),
@EntryUser INT

AS

BEGIN

	INSERT INTO Students (
		StudentName,
		RollNumber,
		ParentID,
		SectionID,
		DateOfBirth,
		GenderID,
		Address,
		Phone,
		Email,
		TransportID,
		Photo,
		EntryUser,
		EntryDate,
		IsDeleted,
		IsPassOut,
		ISDropOut,
		EnrollmentNumber )
	VALUES (
		@StudentName,
		@RollNumber,
		@ParentID,
		@SectionID,
		@DateOfBirth,
		@GenderID,
		@Address,
		@Phone,
		@Email,
		@TransportID,
		@Photo,
		@EntryUser,
		GETDATE(),
		0,
		0,
		0,
		(SELECT (CONVERT(VARCHAR,YEAR(GETDATE())) + '-' + RIGHT('00000' + CONVERT(VARCHAR,ISNULL(MAX(StudentID),0)+1),5)) FROM Students) )

END