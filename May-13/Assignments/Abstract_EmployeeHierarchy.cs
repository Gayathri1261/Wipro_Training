using System;

namespace EmployeeHierarchy
{
    public abstract class Employee
    {
        public abstract void CalculateSalary();
        public void ShowBasicInfo()
        {
            Console.WriteLine("Employee details");
        }
    }
    public class FullTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Salary: Basic + Allowance");
        }
    }
    public class PartTimeEmployee : Employee
    {
        public override void CalculateSalary()
        {
            Console.WriteLine("Salary: Hourly rate × Hours worked");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new FullTimeEmployee();
            employee.ShowBasicInfo();
            employee.CalculateSalary();

            employee = new PartTimeEmployee();
            employee.ShowBasicInfo();
            employee.CalculateSalary();

            Console.ReadLine(); 
        }
    }
}