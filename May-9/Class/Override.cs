using System;
using System.Runtime.CompilerServices;

class Employee
{
    public virtual void work()
    {
        Console.WriteLine("Employee is working.");
    }
}

class Manager : Employee
{
    public override void work()
    {
        Console.WriteLine("Manager is supervising.");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.work(); //CallS base method

        Manager mgr = new Manager();
        mgr.work(); //calls overridden method

        Employee polyEmp = new Manager();
        polyEmp.work();  //calls overridden method
    }
}