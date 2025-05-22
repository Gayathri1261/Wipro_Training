using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Anil", Department = "HR" },
            new Employee { Name = "suresh", Department = "IT" },
            new Employee { Name = "Cherry", Department = "Finance" },
            new Employee { Name = "Deepak", Department = "IT" },
            new Employee { Name = "Kailash", Department = "HR" },
            new Employee { Name = "Srinu", Department = "Finance" }
        };

        var groupedByDept = employees
            .GroupBy(e => e.Department);

        Console.WriteLine("Employees grouped by department:");
        foreach (var group in groupedByDept)
        {
            Console.WriteLine($"\nDepartment: {group.Key}");
            foreach (var emp in group)
            {
                Console.WriteLine($" - {emp.Name}");
            }
        }
    }
}
