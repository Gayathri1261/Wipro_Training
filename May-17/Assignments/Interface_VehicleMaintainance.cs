using System;

interface IMaintenance
{
    void Service();
    void Repair();
}
class CarMaintenance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Car is being serviced");
    }

    public void Repair()
    {
        Console.WriteLine("Car is being repaired");
    }
}
class BikeMaintenance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Bike is being serviced");
    }

    public void Repair()
    {
        Console.WriteLine("Bike is being repaired");
    }
}
class Program
{
    static void Main(string[] args)
    {
        IMaintenance car = new CarMaintenance();
        IMaintenance bike = new BikeMaintenance();

        Console.WriteLine("Car Maintenance Tasks:");
        car.Service();
        car.Repair();

        Console.WriteLine("\nBike Maintenance Tasks:");
        bike.Service();
        bike.Repair();
    }
}