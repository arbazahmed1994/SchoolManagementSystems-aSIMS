USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetTransportByID')
	DROP PROCEDURE GetTransportByID
GO

CREATE PROCEDURE GetTransportByID

@TransportID INT

AS

BEGIN

	SELECT
		TransportID,
		TransportName,
		VehicleNumber,
		NumberOfVehicle,
		DriverCNIC,
		DriverMobile,
		RouteFare,
		Description
	FROM 
		Transport
	WHERE
		TransportID = @TransportID AND
		IsDeleted = 0

END