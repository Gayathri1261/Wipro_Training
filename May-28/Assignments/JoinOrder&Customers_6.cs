//Join orders and customers

using System;
using System.Data.SqlClient;

class Program5
{
   /* static void Main()
    {
        DisplayOrdersWithCustomers();
    }

    static void DisplayOrdersWithCustomers()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"
                SELECT o.OrderID, c.CompanyName, o.OrderDate
                FROM Orders o
                INNER JOIN Customers c ON o.CustomerID = c.CustomerID
                ORDER BY o.OrderDate DESC";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine($"{"OrderID",-10}{"CompanyName",-40}{"OrderDate",-20}");
                Console.WriteLine(new string('-', 70));

                while (reader.Read())
                {
                    int orderId = reader.GetInt32(0);
                    string companyName = reader.GetString(1);
                    DateTime orderDate = reader.GetDateTime(2);

                    Console.WriteLine($"{orderId,-10}{companyName,-40}{orderDate,-20:yyyy-MM-dd}");
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