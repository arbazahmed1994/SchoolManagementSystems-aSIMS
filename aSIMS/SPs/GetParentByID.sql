USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetParentByID')
	DROP PROCEDURE GetParentByID
GO

CREATE PROCEDURE GetParentByID

@ParentID INT 

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
		IsDeleted = 0 AND
		ParentID = @ParentID

END
GO