//Update Employee Title(Parameter Binding)

using System;
using System.Data.SqlClient;

class Program3
{
  /*  static void Main()
    {
        Console.Write("Enter Employee ID: ");
        int employeeId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter New Title: ");
        string newTitle = Console.ReadLine();

        UpdateEmployeeTitle(employeeId, newTitle);
    }

    static void UpdateEmployeeTitle(int employeeId, string title)
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"
                UPDATE Employees 
                SET Title = @title 
                WHERE EmployeeID = @employeeId";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@employeeId", employeeId);

            try
            {
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected > 0
                    ? "Update successful."
                    : "No employee found with the specified ID.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }*/
}
