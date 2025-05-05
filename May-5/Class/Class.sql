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