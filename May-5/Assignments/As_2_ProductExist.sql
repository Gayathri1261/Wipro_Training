//Procedure to check Product Availability
//Task:
//Create a stored procedure named CheckProductExists that:
//->Accepts @ProductID as input
//->Checks whether the product exists in the Products Table
//->Return a message
//->'Product Exists' if Found
//->'Product not found' if it doesnt exists


CREATE PROCEDURE CheckProductExists
	@ProductID INT
AS
BEGIN
		IF Exists(Select 1 from Products Where ProductID =@ProductID)
		BEGIN
			Print 'Product Exists'
		END
		ELSE
		BEGIN
			Print 'Product Not Found'
		END
END;


EXEC CheckProductExists @ProductID = 1;