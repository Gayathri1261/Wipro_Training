using System;
using System.Collections.Generic;

interface IAttendance
{
    void MarkAttendance();
}
abstract class Staff : IAttendance
{
    public int Id;
    public string Name;
    public string Department;

    public Staff(int id, string name, string department)
    {
        Id = id;
        Name = name;
        Department = department;
    }
    public void MarkAttendance()
    {
        Console.WriteLine($"{Name} has marked attendance.");
    }
    public abstract decimal CalculateSalary();
}
class PermanentStaff : Staff
{
    public decimal MonthlySalary;

    public PermanentStaff(int id, string name, string department, decimal monthlySalary)
        : base(id, name, department)
    {
        MonthlySalary = monthlySalary;
    }

    public override decimal CalculateSalary()
    {
        return MonthlySalary; 
    }
}
class ContractStaff : Staff
{
    public int HoursWorked;
    public decimal HourlyRate;

    public ContractStaff(int id, string name, string department, int hoursWorked, decimal hourlyRate)
        : base(id, name, department)
    {
        HoursWorked = hoursWorked;
        HourlyRate = hourlyRate;
    }

    public override decimal CalculateSalary()
    {
        return HoursWorked * HourlyRate; /
    }
}
class Program
{
    static void Main()
    {
        List<Staff> staffList = new List<Staff>
        {
            new PermanentStaff(1, "Alice", "HR", 40000),
            new ContractStaff(2, "Bob", "IT", 80, 300),
            new PermanentStaff(3, "Charlie", "Finance", 50000),
            new ContractStaff(4, "Diana", "Marketing", 60, 250)
        };
        foreach (var staff in staffList)
        {
            staff.MarkAttendance();
            Console.WriteLine($"{staff.Name} ({staff.Department}) - Salary: ₹{staff.CalculateSalary()}\n");
        }
    }
}
