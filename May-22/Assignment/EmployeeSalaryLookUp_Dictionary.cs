using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, decimal> salaryLookup = new Dictionary<int, decimal>
        {
            { 1, 50000.00m },
            { 2, 60000.50m },
            { 3, 55000.75m },
            { 4, 70000.00m },
            { 5, 65000.25m }
        };

        Console.Write("Enter Employee ID to lookup salary: ");
        if (int.TryParse(Console.ReadLine(), out int empId))
        {
            if (salaryLookup.TryGetValue(empId, out decimal salary))
            {
                Console.WriteLine($"Employee ID: {empId}, Salary: {salary:C}");
            }
            else
            {
                Console.WriteLine("Employee ID not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric Employee ID.");
        }
    }
}
