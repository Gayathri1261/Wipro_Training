// Create a Table

Create Table Employees(
	EmployeeID INT Primary Key,
	FirstName VARCHAR(50),
	LastName VARCHAR(50),
	Department VARCHAR(50),
	Salary DECIMAL(10,2),
	HireDate DATE
);

//Insert data into table

Insert INTO Employees (EmployeeID,FirstNAme,LastName,Department,Salary,HireDate) Values
	(1,'Gayathri','Damisetty','Accounting',50000.00,'2025-04-24'),
	(2,'Bharath','Singh','Marketing',25000.00,'2024-01-01'),
	(3,'Satya','Roy','Production',30000.00,'2022-06-15'),
	(4,'Srija','chinni','Sales',20000.00,'2024-07-23');

 //Select 

 Select * from Employees; or Select * from [dbo].[Employees];

 select * from Employees where salary <30000;

 select FirstName,HireDate from Employees where Salary > 30000;

//update 

 Update Employees SET Salary=35000 where EmployeeID=2;

 //Delete
 Delete from Employees Where EmployeeID = 4;

 //Truncate
 Truncate table from Employees;

 // Drop table
 Truncate table from Employees;

