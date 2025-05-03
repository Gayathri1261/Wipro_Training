//Table-1
Create Table Products(
	ProductID INT PRIMARY KEY,
	ProductName VARCHAR(100),
	Price DECIMAL(10,2)
);

//Insert

INSERT INTO Products (ProductID,ProductName,Price) VALUES
	(1,'LAptop',70000.00),
	(2,'Smartphone',30000.00),
	(3,'Tablet',20000.00),
	(4,'Monitor',15000.00)

//Table-2

Create Table Orders(
	OrderID INT PRIMARY KEY,
	ProductID INT,
	Quantity INT,
	OrderDate Date,
	FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

//Insert into table

INSERT INTO Orders(OrderID,ProductID,Quantity,OrderDate) VALUES
	(101,1,2,'2024-12-01'),
	(102,2,1,'2024-12-05'),
	(103,3,3,'2024-12-10'),
	(104,1,1,'2024-12-15'),
	(105,4,2,'2024-12-20');


//INNER JOIN - joining both the tables with similar ID(Orders.ProductID=Products.ProductID)
SELECT
	Orders.OrderID,
	Products.ProductName,
	Orders.Quantity,
	Products.Price,
	(Orders.Quantity * Products.Price) As TotalAmount,
	Orders.OrderDate
From Orders INNER JOIN Products ON Orders.ProductID=Products.ProductID;

//LeftJoin-Every thing from left matching from right.

SELECT
	Products.ProductID,
	Products.ProductName,
	Orders.OrderID,
	Orders.Quantity,
	Orders.OrderDate
From Products LEFT JOIN Orders ON Products.ProductID = Orders.ProductID;

//RightJoin-Every thing from right matching from left.
SELECT
	Products.ProductID,
	Products.ProductName,
	Orders.OrderID,
	Orders.Quantity,
	Orders.OrderDate
From Products Right JOIN Orders ON Products.ProductID = Orders.ProductID;

//Group By

SELECT
	Products.ProductName,
	SUM(Orders.Quantity) AS TotalUnitsSold  // It will sum the quantity and added to totalunits sold
From Orders
INNER JOIN Products ON Orders.ProductID=Products.ProductID
GROUP BY Products.ProductName;  //It will remove the repetitions
