using System;
using System.Collections.Generic;

abstract class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Brand { get; set; }
    public decimal RatePerDay { get; set; }

    public Vehicle(string vehicleNumber, string brand, decimal ratePerDay)
    {
        VehicleNumber = vehicleNumber;
        Brand = brand;
        RatePerDay = ratePerDay;
    }

    public virtual decimal CalculateRent(int days)
    {
        return RatePerDay * days;
    }
}

class Car : Vehicle
{
    public Car(string vehicleNumber, string brand, decimal ratePerDay)
        : base(vehicleNumber, brand, ratePerDay) { }

    public override decimal CalculateRent(int days)
    {
        decimal baseRent = base.CalculateRent(days);
        decimal carSurcharge = 0.10m * baseRent; 
        return baseRent + carSurcharge;
    }
}

class Bike : Vehicle
{
    public Bike(string vehicleNumber, string brand, decimal ratePerDay)
        : base(vehicleNumber, brand, ratePerDay) { }

    public override decimal CalculateRent(int days)
    {
        return base.CalculateRent(days); // No surcharge for bikes
    }
}

class Truck : Vehicle
{
    public Truck(string vehicleNumber, string brand, decimal ratePerDay)
        : base(vehicleNumber, brand, ratePerDay) { }

    public override decimal CalculateRent(int days)
    {
        decimal baseRent = base.CalculateRent(days);
        decimal truckSurcharge = 500m; // Flat surcharge
        return baseRent + truckSurcharge;
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("CAR123", "Toyota", 1500m),
            new Bike("BIKE456", "Yamaha", 500m),
            new Truck("TRUCK789", "Volvo", 3000m)
        };

        Console.WriteLine("Rental Details (for 5 days):\n");
        foreach (var vehicle in vehicles)
        {
            decimal rent = vehicle.CalculateRent(5);
            Console.WriteLine($"{vehicle.GetType().Name} - {vehicle.Brand} ({vehicle.VehicleNumber})");
            Console.WriteLine($"Rate PerDay : {vehicle.RatePerDay:C}, Total Rent: {rent:C}");
            Console.WriteLine();
        }
    }
}
