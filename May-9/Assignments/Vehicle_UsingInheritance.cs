using System;
using System.Security.Cryptography;
//using ConsoleApp1;

class Vehicle
{
    public string Make;
    public string Model;

    //Method to display Vehicle details
    public void DisplayVehicle()
    {
        Console.WriteLine($"Vehicle MAke : {Make}");
        Console.WriteLine($"Model: {Model}");
    }
    
}


//Derived class inheriting from Vehicle
class Car : Vehicle
{
    public string FuelType;

    //Method to display vehicle details
    public void DisplayCar()
    {
        Console.WriteLine($"FuelType: {FuelType}");
    }
}

class Program
{
    static void Main()
    {
        //creating an object of car class
        Car myCar = new Car();
        myCar.Make = "Mahindra";
        myCar.Model = "XUV300";
        myCar.FuelType = "Petrol";

        //Display Vehicle details
        myCar.DisplayVehicle();

        //Displaay car specific details
        myCar.DisplayCar();
    }
}
