using System;

namespace ConsoleApp2
{
    class Employee
    {
        public int empid;
        public string Name;
        public string Department;
        public int salary;

        public void PrintDetails()
        {
            Console.WriteLine($"Employee ID: {empid}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Salary: {salary}");
        }

        public void UpdateSalary(int salary)
        {
            this.salary = salary;
            Console.WriteLine($"Salary Updated to: {salary}");
        }

        public void AnnualSalary()
        {
            Console.WriteLine($"Annual Salary: {salary * 12}");
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp1 = new Employee();
            emp1.empid = 1;
            emp1.Name = "John";
            emp1.Department = "HR";
            emp1.salary = 50000;

            emp1.PrintDetails();
            emp1.UpdateSalary(60000);
            emp1.AnnualSalary();
        }
    }
}