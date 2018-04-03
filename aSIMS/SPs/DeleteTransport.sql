USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='DeleteTransport')
	DROP PROCEDURE DeleteTransport
GO

CREATE PROCEDURE DeleteTransport

@TransportID INT,
@EntryUser INT

AS

BEGIN

	IF (@TransportID = 1)
	BEGIN
		RAISERROR('This ENTITY cannot be Deleted', 16, 1)
		RETURN
	END

	UPDATE Transport SET 
		UpdateUser = @EntryUser, 
		UpdateDate = GETDATE(), 
		IsDeleted =  1
	WHERE
		TransportID = @TransportID

END