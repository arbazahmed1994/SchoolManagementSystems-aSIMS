USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetStudentByID')
	DROP PROCEDURE GetStudentByID
GO

CREATE PROCEDURE GetStudentByID

@StudentID INT

AS

BEGIN

	SELECT 
		StudentID,
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
		UpdateUser,
		UpdateDate,
		IsDeleted,
		IsPassOut,
		ISDropOut,
		EnrollmentNumber
	FROM 
		Students
	WHERE
		StudentID = @StudentID AND
		IsDeleted = 0 AND
		IsPassOut = 0

END
GO