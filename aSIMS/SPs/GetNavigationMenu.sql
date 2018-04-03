USE aSIMS
IF EXISTS (Select 1 FROM sys.objects WHERE type='P' and name='GetNavigationMenu')
	DROP PROCEDURE GetNavigationMenu
GO

CREATE PROCEDURE GetNavigationMenu

@RoleID INT

AS

BEGIN

	SELECT 
		MenuID
		INTO #Menu
	FROM
		RoleAccessRights
	WHERE
		RoleID = RoleID

	SELECT * 
	FROM
		Navbar
	WHERE
		MenuID IN (SELECT MenuID FROM #Menu)

END
GO