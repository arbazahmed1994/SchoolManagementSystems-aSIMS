USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='UpdateTransport')
	DROP PROCEDURE UpdateTransport
GO

CREATE PROCEDURE UpdateTransport

@TransportID INT,
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

	IF (@TransportID = 1)
	BEGIN
		RAISERROR('This ENTITY cannot be Updated', 16, 1)
		RETURN
	END

	UPDATE Transport SET  
		TransportName = @TransportName,	
		VehicleNumber = @VehicleNumber, 
		DriverCNIC = @DriverCNIC, 
		DriverMobile = @DriverMobile, 
		RouteArea = @RouteArea,
		RouteFare = @RouteFare,
		NumberOfVehicle = @NumberOfVehicle,
		Description = @Description,
		UpdateUser = @EntryUser, 
		UpdateDate = GETDATE(), 
		IsDeleted =  0
	WHERE
		TransportID = @TransportID

END