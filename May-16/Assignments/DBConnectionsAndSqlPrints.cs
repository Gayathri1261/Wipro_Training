using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Step 1: Create the connection string (database details)
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=SSPI";

        try
        {
            // Step 2: Open a connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open(); // Open the connection

                // Step 3: Write the SQL query
                string query = "SELECT ContactName, City, CompanyName FROM Customers";

                // Step 4: Create a command to run the query
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Step 5: Execute the command and get the results
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Step 6: Check if we got any data
                        if (reader.HasRows)
                        {
                            // Print column titles
                            Console.WriteLine("Contact Name                    City                  Company Name");
                            Console.WriteLine("--------------                ------------           ---------------");

                           // Console.WriteLine("{0,-30} {1,-20} {2,-40}", "Contact Name", "City", "Company Name");
                           // Console.WriteLine(new string('-', 95));

                            // Step 7: Read each row one by one
                            while (reader.Read())
                            {
                                // Get data from each column safely
                                string contactName = reader["ContactName"].ToString();
                                string city = reader["City"].ToString();
                                string companyName = reader["CompanyName"].ToString();

                                // Print the data
                                Console.WriteLine("{0,-30} {1,-20} {2,-40}", contactName, city, companyName);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            // If any error happens, show it
            Console.WriteLine("Error: " + ex.Message);
        }

        // Step 8: Keep the console open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

}