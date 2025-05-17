using System;

abstract class Animal
{
    public abstract void MakeSound();

    public void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
}
class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Barks");
    }
}
class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Meows");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Animal dog = new Dog();
        Animal cat = new Cat();

        Console.WriteLine("Dog Behavior:");
        dog.Eat();
        dog.MakeSound();

        Console.WriteLine("\nCat Behavior:");
        cat.Eat();
        cat.MakeSound();
    }
}