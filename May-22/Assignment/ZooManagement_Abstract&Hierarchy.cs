using System;
using System.Collections.Generic;

abstract class Animal
{
    public string Name;
    public int Age;

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void MakeSound();

    public void Feed()
    {
        Console.WriteLine($"{Name} is being fed.");
    }
}

class Lion : Animal
{
    public Lion(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Lion roars!");
    }
}

class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Elephant trumpets!");
    }
}

class Monkey : Animal
{
    public Monkey(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the Monkey chatters!");
    }
}

class Zoo
{
    public List<Animal> Animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }

    public void ShowAllAnimals()
    {
        foreach (var animal in Animals)
        {
            Console.WriteLine($"\n{animal.Name}, Age: {animal.Age}");
            animal.MakeSound();
            animal.Feed();
        }
    }
}

class Program
{
    static void Main()
    {
        Zoo zoo = new Zoo();

        zoo.AddAnimal(new Lion("Simba", 5));
        zoo.AddAnimal(new Elephant("Dumbo", 10));
        zoo.AddAnimal(new Monkey("Chico", 3));

        zoo.ShowAllAnimals();
    }
}
