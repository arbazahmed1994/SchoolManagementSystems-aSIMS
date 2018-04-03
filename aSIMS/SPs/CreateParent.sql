USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateParent')
	DROP PROCEDURE CreateParent
GO

CREATE PROCEDURE CreateParent

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

	INSERT INTO Parents (
		ParentName,
		Email,
		Password,
		Phone,
		Mobile,
		Address,
		Profession,
		EntryUser,
		EntryDate,
		IsDeleted )
	VALUES (
		@ParentName,
		@Email,
		@Password,
		@Phone,
		@Mobile,
		@Address,
		@Profession,
		@EntryUser,
		GETDATE(),
		0 )

END