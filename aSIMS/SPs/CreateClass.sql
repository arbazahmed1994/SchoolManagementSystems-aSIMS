USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateClass')
	DROP PROCEDURE CreateClass
GO

CREATE PROCEDURE CreateClass

@ClassName VARCHAR(30),
@ClassNumericName VARCHAR(20)

AS

BEGIN

	INSERT INTO Classes ( 
		ClassName,
		ClassNumericName )
	VALUES (
		@ClassName,
		@ClassNumericName )

END
GO