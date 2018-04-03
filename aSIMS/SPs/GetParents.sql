USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetParents')
	DROP PROCEDURE GetParents
GO

CREATE PROCEDURE GetParents

AS 

BEGIN

	SELECT 
		ParentID,
		ParentName,
		Email,
		Password,
		Phone,
		Mobile,
		Address,
		Profession,
		EntryUser,
		EntryDate,
		UpdateUser,
		UpdateDate,
		IsDeleted
	FROM
		Parents
	WHERE
		IsDeleted = 0

END
GO