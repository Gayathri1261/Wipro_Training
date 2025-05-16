using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Connection string to the database
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";

        // SQL query to join Suppliers and Products tables
        string query = "SELECT Suppliers.City, Suppliers.CompanyName, Products.UnitPrice, Products.ProductName " +
                       "FROM Suppliers INNER JOIN Products ON Suppliers.SupplierID = Products.SupplierID";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // Print header using formatting
                    Console.WriteLine("{0,-25} {1,-35} {2,-20} {3,-35}", "City", "Company", "Unit Price", "Product Name");
                    Console.WriteLine(new string('-', 100));

                    while (reader.Read())
                    {
                        string city = reader["City"].ToString();
                        string company = reader["CompanyName"].ToString();
                        string price = reader["UnitPrice"].ToString();
                        string product = reader["ProductName"].ToString();

                        // Print data using formatted columns
                        Console.WriteLine("{0,-25} {1,-35} {2,-20} {3,-35}", city, company, price, product);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}