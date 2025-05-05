//Stored Procedures

CREATE PROCEDURE GetAllProducts
AS
BEGIN
SELECT * FROM PRODUCTS END;


Exec GetAllProducts;

//Task - Create a procedure as HigherEndProducts and diplay the products where  price > 60000

CREATE PROCEDURE HigherEndProducts
AS
BEGIN
SELECT * FROM PRODUCTS Where Price > 60000 END;

Exec HigherEndProducts;


CREATE PROCEDURE GetOrdersByProduct
	@ProductID INT
AS
BEGIN
	SELECT
		o.OrderID,
		o.Quantity,
		o.OrderDate,
		p.ProductName,
		p.Price
	FROM Orders o
	INNER JOIN Products p ON o.ProductID = p.ProductID
	WHERE o.ProductID = @ProductID;
END;


EXEC GetOrdersByProduct @ProductID = 1;



Transaction

BEGIN TRANSACTION;
UPDATE Employees
SET Salary = Salary+2000
Where Department = 'Accounting';
COMMIT;

Example-2 Roll back
Begin Transaction;
Delete from Students Where Marks <60;
Rollback;  //When the mistake is happened in the student data the roolback is used.

Example 3:SavePoint With ROLLBACK to 

BEGIN TRANSACTION;
UPDATE EmployeesSET Salary = Salary + 1000
WHERE EmployeeID = 1;

SAVE TRANSACTION IncreaseJohn;

UPDATE EmployeesSET Salary = Salary + 1000
WHERE EmployeeID = 2;

---Oops,rollback second increment only

ROLLBACK TRANSACTION IncreaseJohn;
COMMIT;

What are Window Functions?
Window functions perform calculation acress a set of rows(a window) related to the current row without collapsing rows like GROUP BY.
1.OVER()
SELECT
	Name,
	Department,
	Salary,
	AVG(Salary) OVER() AS AvgSalary ---Calculates average over all rows
From Employees;

2.PARTITIONBY(Group-wise analysis)
SELECT
	Name,
	Department,
	Salary,
	AVG(Salary) OVER(PARTITION BY Department) AS DeptAvgSalary
From Employees;

3.Ranking Functions

SELECT
	FirstName,
	Department,
	Salary,
	ROW_NUMBER() OVER(PARTITION BY Department ORDER BY Salary DESC) AS RowNum
From Employees;

RANK()

SELECT
	FirstName,
	Salary,
	RANK() OVER(ORDER BY Salary DESC) AS RankBySalary
From Employees;

