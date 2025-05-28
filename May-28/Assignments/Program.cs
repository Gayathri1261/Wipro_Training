//Display all the customers

using System;
using System.Data.SqlClient;

class Program
{
   /*static void Main()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT CustomerID, CompanyName, Country FROM Customers";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Header
                Console.WriteLine(
                    "{0,-15} {1,-50} {2,-30}",
                    "CustomerID", "CompanyName", "Country"
                );
                Console.WriteLine(new string('-', 100));

                // Data rows
                while (reader.Read())
                {
                    string customerId = reader["CustomerID"].ToString();
                    string companyName = reader["CompanyName"].ToString();
                    string country = reader["Country"].ToString();

                    Console.WriteLine(
                        "{0,-15} {1,-50} {2,-30}",
                        customerId, companyName, country
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
