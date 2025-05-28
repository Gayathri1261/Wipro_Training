using System;
using System.Data.SqlClient;

class Program2
{

    //insert values into product table
   /* static void Main()
    {
        InsertProduct("Test Product", 1, 1, 25m);
    }

    static void InsertProduct(string productName, int supplierId, int categoryId, decimal unitPrice)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"
                INSERT INTO Products (ProductName, SupplierID, CategoryID, UnitPrice)
                VALUES (@productName, @supplierId, @categoryId, @unitPrice)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@supplierId", supplierId);
            command.Parameters.AddWithValue("@categoryId", categoryId);
            command.Parameters.AddWithValue("@unitPrice", unitPrice);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine($"Insert successful. Rows affected: {rowsAffected}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }*/
}