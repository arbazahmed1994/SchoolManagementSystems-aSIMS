USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='UpdateParent')
	DROP PROCEDURE UpdateParent
GO

CREATE PROCEDURE UpdateParent

@ParentID INT,
@ParentName VARCHAR(50),
@Email VARCHAR(50),
@Password VARCHAR(25),
@Phone VARCHAR(20),
@Mobile VARCHAR(20),
@Address VARCHAR(100),
@Profession VARCHAR(50),
@EntryUser INT

AS

BEGIN

	UPDATE Parents SET
		ParentName = @ParentName ,
		Email = @Email,
		Password = @Password,
		Phone = @Phone,
		Mobile = @Mobile,
		Address = @Address,
		Profession = @Profession,
		UpdateUser = @EntryUser,
		UpdateDate = GETDATE()
	WHERE
		ParentID = @ParentID

END