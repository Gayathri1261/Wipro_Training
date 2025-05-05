CREATE PROCEDURE ProductRevenue
	@ProductID INT
AS
BEGIN
	SELECT(orders.quantity * products.price) AS TotalRevenue
	FROM orders 
	INNER JOIN products ON orders.productid = products.productid
	WHERE orders.productid = @ProductID;
END


EXEC ProductRevenue @ProductID=1;

