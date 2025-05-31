using System;
using System.Collections.Generic;

interface IRentable
{
    void Rent(int days);
    double GetRentPrice(int days);
}

abstract class Vehicle : IRentable
{
    public string Name { get; set; }
    public double PricePerDay { get; set; }

    public Vehicle(string name, double pricePerDay)
    {
        Name = name;
        PricePerDay = pricePerDay;
    }

    public abstract void Rent(int days);

    public double GetRentPrice(int days)
    {
        return PricePerDay * days;
    }
}

class Car : Vehicle
{
    public Car(string name, double pricePerDay) : base(name, pricePerDay) {}

    public override void Rent(int days)
    {
        Console.WriteLine($"Car {Name} rented for {days} days. Total: ${GetRentPrice(days)}");
    }
}

class Bike : Vehicle
{
    public Bike(string name, double pricePerDay) : base(name, pricePerDay) {}

    public override void Rent(int days)
    {
        Console.WriteLine($"Bike {Name} rented for {days} days. Total: ${GetRentPrice(days)}");
    }
}

class Truck : Vehicle
{
    public Truck(string name, double pricePerDay) : base(name, pricePerDay) {}

    public override void Rent(int days)
    {
        Console.WriteLine($"Truck {Name} rented for {days} days. Total: ${GetRentPrice(days)}");
    }
}

class Program
{
    static void Main()
    {
        List<IRentable> vehicles = new List<IRentable>
        {
            new Car("Small Car", 40),
            new Bike("Fast Bike", 10),
            new Truck("Big Truck", 100)
        };

        Console.WriteLine("Welcome to the Vehicle Rental System!\n");

        for (int i = 0; i < vehicles.Count; i++)
        {
            Vehicle v = (Vehicle)vehicles[i];
            Console.WriteLine($"{i + 1}. {v.Name} - ${v.PricePerDay} per day");
        }

        Console.WriteLine("\nRenting all vehicles for 2 days:\n");

        foreach (IRentable vehicle in vehicles)
        {
            vehicle.Rent(2);
        }
    }
}
