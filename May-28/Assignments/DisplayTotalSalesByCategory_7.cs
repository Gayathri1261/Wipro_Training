using System;
using System.Data;
using System.Data.SqlClient;

class Program6
{
  /*  static void Main()
    {
        DisplayTotalSalesByCategory();
    }

    static void DisplayTotalSalesByCategory()
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=true";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = @"
                SELECT p.CategoryID, 
                       SUM(od.UnitPrice * od.Quantity) AS TotalSales
                FROM [Order Details] od
                INNER JOIN Products p ON od.ProductID = p.ProductID
                GROUP BY p.CategoryID";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();

            try
            {
                adapter.Fill(table);

                Console.WriteLine($"{"CategoryID",-15}{"Total Sales",-20}");
                Console.WriteLine(new string('-', 35));

                foreach (DataRow row in table.Rows)
                {
                    int categoryId = Convert.ToInt32(row["CategoryID"]);
                    decimal totalSales = Convert.ToDecimal(row["TotalSales"]);

                    Console.WriteLine($"{categoryId,-15}{totalSales,-20:C}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }*/
}
