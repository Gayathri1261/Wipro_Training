CREATE TABLE Students(
	StudentID INT PRIMARY KEY,
	FirstName VARCHAR(50),
	Marks INT,
	DOB Date
);

Insert INTO Students (StudentID,FirstNAme,Marks,DOB) Values
	(1,'Gayathri',98,'2001-06-12'),
	(2,'Bharath',80,'2002-01-01'),
	(3,'Satya',70,'2003-06-15'),
	(4,'Srija',68,'2005-07-23');

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

//Scaled functions
1.	Select FirstName,UPPER(FirstName) AS UpperName from Students;

2.	Select FirstName,DATEDIFF(Year,DOB,GETDATE()) AS Age from Students;

3.	Select Department,MAX(Salary) AS HighestSalary from Employees Group By Department;

Aggregate Functions
4.  Select COUNT(*) AS TotalStudents from Students;

5.  Select AVG(Marks) AS AverageMarks from Students;

6.	Select Department,MAX(Salary) AS HighestSalary from Employees Group By Department;

7.
Select FirstName,Marks,
	CASE
		When Marks >= 90 Then 'A'
		When Marks >= 75 Then 'B'
		When Marks >= 60 Then 'C'
		ELSE 'D'
	END AS Grade
From Students;	

8.
Select FirstName,Salary,
	CASE
		When Salary>= 70000 Then 'High'
		When Salary>= 50000 Then 'Medium'
		ELSE 'Low'
	END AS SalaryBand
From Employees;