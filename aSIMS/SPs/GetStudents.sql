USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetStudents')
	DROP PROCEDURE GetStudents
GO

CREATE PROCEDURE GetStudents

AS

BEGIN

	SELECT 
		StudentID,
		StudentName,
		RollNumber,
		P.ParentName,
		C.ClassName + ' - ' + SE.SectionName AS SectionName,
		DateOfBirth,
		G.GenderName,
		S.Address,
		S.Phone,
		S.Email,
		T.TransportName,
		Photo,
		S.EntryUser,
		S.EntryDate,
		S.UpdateUser,
		S.UpdateDate,
		S.IsDeleted,
		IsPassOut,
		ISDropOut,
		EnrollmentNumber
	FROM 
		Students AS S
		INNER JOIN Gender AS G ON G.GenderID = S.GenderID
		INNER JOIN	Parents AS P ON P.ParentID = P.ParentID
		INNER JOIN Transport AS T ON T.TransportID = S.TransportID
		INNER JOIN Sections AS SE ON SE.SectionID = S.SectionID 
		INNER JOIN Classes AS C ON C.ClassID = SE.ClassID
	WHERE
		S.IsDeleted = 0 AND
		S.IsPassOut = 0

END
GO