USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetTransport')
	DROP PROCEDURE GetTransport
GO

CREATE PROCEDURE GetTransport

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

END