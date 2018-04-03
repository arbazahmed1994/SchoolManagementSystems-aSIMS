USE aSIMS

-- Employee Account

INSERT INTO EmployeeAccount VALUES ( '0001','Admin','123123','Administrator', )

-- Navbar Data

INSERT INTO Navbar (MenuID, LinkText , ActionName , ControllerName , Icon , ParentID , ShowInMenu , IsParent , SequenceNumber) 
VALUES (1,'Dashboard' , 'Index' , 'Home' , 'fa fa-th' , NULL , 1 , 0 , 1)

INSERT INTO Navbar (MenuID, LinkText , ActionName , ControllerName , Icon , ParentID , ShowInMenu , IsParent , SequenceNumber) 
VALUES (2,'Emp. Accounts' , '' , '' , 'fa fa-users' , NULL , 1 , 1 , 2)
	INSERT INTO Navbar (MenuID, LinkText , ActionName , ControllerName , Icon , ParentID , ShowInMenu , IsParent , SequenceNumber) 
	VALUES (3,'Accounts List' , 'Index' , 'EmployeeAccount' , 'fa fa-users' , 2 , 1 , 0 , 1)
	INSERT INTO Navbar (MenuID, LinkText , ActionName , ControllerName , Icon , ParentID , ShowInMenu , IsParent , SequenceNumber) 
	VALUES (4,'Create Account' , 'Create' , 'EmployeeAccount' , 'fa fa-users' , 2 , 1 , 0 , 2)

INSERT INTO Navbar (MenuID, LinkText , ActionName , ControllerName , Icon , ParentID , ShowInMenu , IsParent , SequenceNumber) 
VALUES (5,'Teachers' , '' , '' , 'fa fa-user' , NULL , 1 , 1 , 3)
	INSERT INTO Navbar (MenuID, LinkText , ActionName , ControllerName , Icon , ParentID , ShowInMenu , IsParent , SequenceNumber) 
	VALUES (6,'Teachers List' , 'Index' , 'Teacher' , 'fa fa-users' , 5 , 1 , 0 , 1)
	INSERT INTO Navbar (MenuID, LinkText , ActionName , ControllerName , Icon , ParentID , ShowInMenu , IsParent , SequenceNumber) 
	VALUES (7,'Create Teacher' , 'Create' , 'Teacher' , 'fa fa-users' , 5 , 1 , 0 , 2)

INSERT INTO Navbar (MenuID, LinkText , ActionName , ControllerName , Icon , ParentID , ShowInMenu , IsParent , SequenceNumber) 
VALUES (8,'Parents' , '' , '' , 'fa fa-user' , NULL , 1 , 1 , 4)
	INSERT INTO Navbar (MenuID, LinkText , ActionName , ControllerName , Icon , ParentID , ShowInMenu , IsParent , SequenceNumber) 
	VALUES (9,'Parents List' , 'Index' , 'Parent' , 'fa fa-users' , 8 , 1 , 0 , 1)
	INSERT INTO Navbar (MenuID, LinkText , ActionName , ControllerName , Icon , ParentID , ShowInMenu , IsParent , SequenceNumber) 
	VALUES (10,'Create Parent' , 'Create' , 'Parent' , 'fa fa-users' , 8 , 1 , 0 , 2)

INSERT INTO Navbar (MenuID, LinkText , ActionName , ControllerName , Icon , ParentID , ShowInMenu , IsParent , SequenceNumber) 
VALUES (11,'Classes' , '' , '' , 'fa fa-code-fork' , NULL , 1 , 1 , 5)
	INSERT INTO Navbar (MenuID, LinkText , ActionName , ControllerName , Icon , ParentID , ShowInMenu , IsParent , SequenceNumber) 
	VALUES (12,'Classes List' , 'Index' , 'Classes' , 'fa fa-code-fork' , 11 , 1 , 0 , 1)
	INSERT INTO Navbar (MenuID, LinkText , ActionName , ControllerName , Icon , ParentID , ShowInMenu , IsParent , SequenceNumber) 
	VALUES (13,'Create Class' , 'Create' , 'Classes' , 'fa fa-code-fork' , 11 , 1 , 0 , 2)
	INSERT INTO Navbar (MenuID, LinkText , ActionName , ControllerName , Icon , ParentID , ShowInMenu , IsParent , SequenceNumber) 
	VALUES (14,'Sections List' , 'SectionIndex' , 'Classes' , 'fa fa-code-fork' , 11 , 1 , 0 , 1)
	INSERT INTO Navbar (MenuID, LinkText , ActionName , ControllerName , Icon , ParentID , ShowInMenu , IsParent , SequenceNumber) 
	VALUES (15,'Create Section' , 'SectionCreate' , 'Classes' , 'fa fa-code-fork' , 11 , 1 , 0 , 2)


-- GENDER

INSERT INTO GENDER VALUES ('Male')
INSERT INTO GENDER VALUES ('Female')

-- CITY

INSERT INTO City VALUES ('Karachi')

-- DESIGNATION

INSERT INTO Designation VALUES ('Admin')
INSERT INTO Designation VALUES ('Teacher')
INSERT INTO Designation VALUES ('Junior Teacher')
INSERT INTO Designation VALUES ('Principal')
INSERT INTO Designation VALUES ('Vice Principal')
INSERT INTO Designation VALUES ('Primary Incharge')
INSERT INTO Designation VALUES ('Secondary Incharge')
INSERT INTO Designation VALUES ('Senior Accountant')
INSERT INTO Designation VALUES ('Accountant')

-- USER TYPE

INSERT INTO UserType VALUES ('Teacher')
INSERT INTO UserType VALUES ('Administrator')

-- GROUP SECTION

INSERT INTO GroupSection VALUES ('Kindergarden')
INSERT INTO GroupSection VALUES ('Primary')
INSERT INTO GroupSection VALUES ('Secondary')

-- ACCOUNT ROLE

INSERT INTO AccountRole VALUES ('Accountant', NULL, 2)
INSERT INTO AccountRole VALUES ('Teacher', NULL, 1)
INSERT INTO AccountRole VALUES ('Principal', NULL, 2)
INSERT INTO AccountRole VALUES ('Incharge', NULL, 2)
INSERT INTO AccountRole VALUES ('Admin', NULL, 1)

-- Role Access Right

INSERT INTO RoleAccessRights VALUES ( 5 , 1)
INSERT INTO RoleAccessRights VALUES ( 5 , 2)
INSERT INTO RoleAccessRights VALUES ( 5 , 3)
INSERT INTO RoleAccessRights VALUES ( 5 , 4)
