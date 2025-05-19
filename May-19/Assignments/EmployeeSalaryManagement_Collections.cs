using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(int id, string name, decimal salary)
    {
        EmployeeID = id;
        Name = name;
        Salary = salary;
    }
}
public class Program
{
    public static void Main()
    {
        // Create a List<Employee>
        List<Employee> employeeList = new List<Employee>
        {
            new Employee(101, "Alice", 55000),
            new Employee(102, "Bob", 72000),
            new Employee(103, "Charlie", 68000),
            new Employee(104, "Diana", 80000),
            new Employee(105, "Ethan", 60000)
        };
        Employee highestPaid = employeeList.OrderByDescending(e => e.Salary).First();
        Console.WriteLine($"Highest Paid Employee: {highestPaid.Name}, Salary: {highestPaid.Salary:C}");
        
        Dictionary<int, string> employeeDict = new Dictionary<int, string>();
        foreach (var emp in employeeList)
        {
            employeeDict[emp.EmployeeID] = emp.Name;
        }


        Console.WriteLine("\nEmployee Directory:");
        foreach (var kvp in employeeDict)
        {
            Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
        }

        Console.WriteLine("\nEnter Employee ID to search:");
        if (int.TryParse(Console.ReadLine(), out int searchID))
        {
            if (employeeDict.TryGetValue(searchID, out string employeeName))
            {
                Console.WriteLine($"Employee Found: {employeeName}");
            }
            else
            {
                Console.WriteLine("Employee ID not found.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid ID.");
        }
    }
}