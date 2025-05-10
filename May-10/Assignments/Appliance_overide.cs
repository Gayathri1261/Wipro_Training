//Task1: Appliance and WashingMachine
//Create a base class Appliance with a virtual method Operate().
//Create a derived class WashingMachine that overrides Operate() to print "Washing clothes".
//Test the base and derived methods.

using System;

public class Appliance
{
    public virtual void Operate()
    {
        Console.WriteLine ("Operating Appliance.");
    }
}

class WashingMachine :Appliance
{
    public override void Operate()
    {
        Console.WriteLine("Washing clothes");
    }
}
class Program
{
    static void Main()
    {
      
        Appliance appliance = new Appliance();
        Appliance washingMachine = new WashingMachine();
        appliance.Operate(); // Output: Operating appliance
        
        WashingMachine WM= new WashingMachine();
        WM.Operate(); // Output: Washing clothes
    }
}