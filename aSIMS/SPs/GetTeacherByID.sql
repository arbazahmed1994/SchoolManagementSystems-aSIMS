USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetTeacherByID')
	DROP PROCEDURE GetTeacherByID
GO

CREATE PROCEDURE GetTeacherByID

@TeacherID INT 

AS

BEGIN

	SELECT 
		TeacherID,
		TeacherName,
		DateOfBirth,
		Address,
		Phone,
		Mobile,
		Email,
		UserName,
		Password,
		Qualification,
		CNIC,
		IsDeleted,
		EntryUser,
		EntryDate,
		UpdateUser,
		UpdateDate,
		RoleID,
		GenderID,
		CityID,
		DesignationID
	FROM 
		Teachers AS T
	WHERE
		T.IsDeleted = 0 AND
		TeacherID = @TeacherID

END