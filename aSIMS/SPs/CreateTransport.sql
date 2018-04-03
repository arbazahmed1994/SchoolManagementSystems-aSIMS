USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='CreateTransport')
	DROP PROCEDURE CreateTransport
GO

CREATE PROCEDURE CreateTransport

@TransportName VARCHAR(50),
@RouteArea VARCHAR(100),
@NumberOfVehicle INT,
@RouteFare FLOAT,
@Description VARCHAR(200),
@EntryUser INT,
@DriverCNIC VARCHAR(20),
@VehicleNumber VARCHAR(20),
@DriverMobile VARCHAR(20)

AS

BEGIN

	INSERT INTO Transport ( 
		TransportName ,	
		VehicleNumber , 
		DriverCNIC , 
		DriverMobile , 
		RouteArea ,
		RouteFare ,
		NumberOfVehicle ,
		Description ,
		EntryUser , 
		EntryDate , 
		IsDeleted )
	VALUES (
		@TransportName,
		@VehicleNumber,
		@DriverCNIC,
		@DriverMobile,
		@RouteArea ,
		@RouteFare ,
		@NumberOfVehicle ,
		@Description ,
		@EntryUser ,
		GETDATE() ,
		0 )

END