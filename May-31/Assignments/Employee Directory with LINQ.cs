using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Ravi", Department = "HR", Salary = 50000 },
            new Employee { Id = 2, Name = "Lakshmi", Department = "IT", Salary = 70000 },
            new Employee { Id = 3, Name = "Srinivas", Department = "IT", Salary = 80000 },
            new Employee { Id = 4, Name = "Bhanu", Department = "Finance", Salary = 60000 },
            new Employee { Id = 5, Name = "Keerthi", Department = "HR", Salary = 55000 }
        };
        Console.WriteLine("Employees in IT Department:");
        var itEmployees = employees.Where(emp => emp.Department == "IT");

        foreach (var emp in itEmployees)
        {
            Console.WriteLine($"{emp.Name} - ₹{emp.Salary}");
        }

        Console.WriteLine();

        Console.WriteLine("All Employees Sorted by Salary (Descending):");
        var sortedEmployees = employees.OrderByDescending(emp => emp.Salary);

        foreach (var emp in sortedEmployees)
        {
            Console.WriteLine($"{emp.Name} ({emp.Department}) - ₹{emp.Salary}");
        }

        Console.WriteLine();

        Console.WriteLine("Average Salary per Department:");
        var avgSalaryByDept = employees
            .GroupBy(emp => emp.Department)
            .Select(group => new
            {
                Department = group.Key,
                AverageSalary = group.Average(emp => emp.Salary)
            });

        foreach (var item in avgSalaryByDept)
        {
            Console.WriteLine($"{item.Department} - ₹{item.AverageSalary:F2}");
        }
    }
}