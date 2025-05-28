//Search orders by Customer ID

using System;
using System.Data.SqlClient;

class Program1
{
  /*  static void Main()
    {
        Console.Write("Enter Customer ID: ");
        string customerId = Console.ReadLine();

        GetOrdersByCustomer(customerId);
    }

    static void GetOrdersByCustomer(string customerId)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"
                SELECT OrderID, OrderDate, ShipCountry 
                FROM Orders 
                WHERE CustomerID = @customerId";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@customerId", customerId);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                Console.WriteLine(
                    "{0,-10} {1,-20} {2,-30}",
                    "OrderID", "OrderDate", "ShipCountry"
                );
                Console.WriteLine(new string('-', 60));

                while (reader.Read())
                {
                    int orderId = Convert.ToInt32(reader["OrderID"]);
                    DateTime orderDate = Convert.ToDateTime(reader["OrderDate"]);
                    string shipCountry = reader["ShipCountry"].ToString();

                    Console.WriteLine(
                        "{0,-10} {1,-20} {2,-30}",
                        orderId, orderDate.ToShortDateString(), shipCountry
                    );
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