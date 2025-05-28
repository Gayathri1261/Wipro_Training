using System;
using System.Data.SqlClient;

class Program4
{
   /* static void Main()
    {
        Console.Write("Enter Product Name to delete: ");
        string productName = Console.ReadLine();

        DeleteProductByName(productName);
    }

    static void DeleteProductByName(string productName)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";


        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "DELETE FROM Products WHERE ProductName = @productName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@productName", productName);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                Console.WriteLine(rowsAffected > 0
                    ? "Product deleted successfully."
                    : "No product found with the specified name.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }*/
}