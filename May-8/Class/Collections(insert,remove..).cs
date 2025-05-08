using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string>() { "Apple", "Banana", "Cherry" };
        //Adding an element
        fruits.Add("Orange");

        //Inserting an element at index 1
        fruits.Insert(1, "Mango");

        //Removing an element by value
        fruits.Remove("Banana");

        //Removing an element at index
        fruits.RemoveAt(2);

        //Checking if an element exists
        if (fruits.Contains("Apple"))
            Console.WriteLine("Apple is in the list:");
        //Sorting the list
        fruits.Sort();

        //Printing the final list
        Console.WriteLine("Fruits list");
        foreach(string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }    
   }
}