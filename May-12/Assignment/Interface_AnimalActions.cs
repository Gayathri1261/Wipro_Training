using System;

// Define the Interface
interface IAnimalActions
{
    void Eat();
    void Sleep();
}
//Implement Lion Class
class Lion : IAnimalActions
{
    public void Eat()
    {
        Console.WriteLine("Lion is eating meat");
    }
    public void Sleep()
    {
        Console.WriteLine("Lion is sleeping");
    }
}
//Implement Elephant Class
class Elephant : IAnimalActions
{
    public void Eat()
    {
        Console.WriteLine("Elephant is eating grass");
    }
    public void Sleep()
    {
        Console.WriteLine("Elephant is sleeping");
    }
}
// Main Method to Test the Classes
class Program
{
    static void Main(string[] args)
    {
        // Create IAnimalActions reference for Lion
        IAnimalActions lion = new Lion();
        lion.Eat();
        lion.Sleep();

        Console.WriteLine();

        // Create IAnimalActions reference for Elephant
        IAnimalActions elephant = new Elephant();
        elephant.Eat();
        elephant.Sleep();
    }
}