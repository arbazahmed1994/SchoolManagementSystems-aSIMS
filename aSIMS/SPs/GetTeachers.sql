USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetTeachers')
	DROP PROCEDURE GetTeachers
GO

CREATE PROCEDURE GetTeachers

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
		AR.RoleName,
		G.GenderName,
		C.CityName,
		D.DesignationName
	FROM 
		Teachers AS T
		INNER JOIN Designation AS D ON D.DesignationID = T.DesignationID
		INNER JOIN Gender AS G ON G.GenderID = T.GenderID
		INNER JOIN AccountRole AS AR ON AR.RoleID = T.RoleID
		INNER JOIN City AS C ON C.CityID = T.CityID
	WHERE
		T.IsDeleted = 0

END