using System;
using System.Collections.Generic;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
}
class Program
{
    static void Main()
    {
        //Create a list employee names
        List<string> employeeNames = new List<string>();

        //Add 5 employees
        employeeNames.Add("Gayi");
        employeeNames.Add("Srinu");
        employeeNames.Add("Roopa");
        employeeNames.Add("Bharath");
        employeeNames.Add("Ramesh");

        //Remove an employee by name
        employeeNames.Remove("Ramesh");

        //Check if a specific name exists
        if (employeeNames.Contains("Ramesh"))
            Console.WriteLine("Ramesh is in the list:");
        else
            Console.WriteLine("Ramesh is not in the list:");

        //Print the total number of employees

        Console.WriteLine("Employees list");
        foreach (string Employee in employeeNames)
        {
            Console.WriteLine(Employee);
        }
    }
}