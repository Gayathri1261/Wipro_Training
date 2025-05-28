using System;
using System.Data.SqlClient;

class Program7
{
   /* static void Main()
    {
        Console.Write("Enter Customer ID: ");
        string customerId = Console.ReadLine();

        ShowCustomerProductUnitPrices(customerId);
    }

    static void ShowCustomerProductUnitPrices(string customerId)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"
                SELECT DISTINCT p.ProductName, p.UnitPrice
                FROM Customers c
                JOIN Orders o ON c.CustomerID = o.CustomerID
                JOIN [Order Details] od ON o.OrderID = od.OrderID
                JOIN Products p ON od.ProductID = p.ProductID
                WHERE c.CustomerID = @customerId";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerId", customerId);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine();
                Console.WriteLine("ProductName                             UnitPrice");
                Console.WriteLine("--------------------------------------------------");

                while (reader.Read())
                {
                    string productName = reader["ProductName"].ToString();
                    decimal unitPrice = Convert.ToDecimal(reader["UnitPrice"]);

                    Console.WriteLine($"{productName,-40}{unitPrice,10:C}");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }*/
}
