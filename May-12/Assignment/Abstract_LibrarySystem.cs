using System;

//Define the Abstract Class
abstract class Book
{
    // Abstract method (must be implemented in derived classes)
    public abstract void Read();

    // Concrete method
    public void GetInfo()
    {
        Console.WriteLine("This is a book");
    }
}

// Implement FictionBook Class
class FictionBook : Book
{
    public override void Read()
    {
        Console.WriteLine("Reading a fiction book");
    }
}

//Implement ScienceBook Class
class ScienceBook : Book
{
    public override void Read()
    {
        Console.WriteLine("Reading a science book");
    }
}

// Main Method to Test the Classes
class Program
{
    static void Main(string[] args)
    {
        // Book reference for FictionBook object
        Book fiction = new FictionBook();
        fiction.GetInfo();
        fiction.Read();

        Console.WriteLine();

        // Book reference for ScienceBook object
        Book science = new ScienceBook();
        science.GetInfo();
        science.Read();
    }
}