using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Please enter 10 numbers:");
        for (int i = 0; i < 10; i++)
        {
            int inputNumber;
            while (!int.TryParse(Console.ReadLine(), out inputNumber))
            {
                Console.WriteLine("Invalid input.");

            }
            numbers.Add(inputNumber);
        }
            HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

            Console.WriteLine("\nUnique numbers:");
            foreach (int num in uniqueNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine($"\nTotal unique elements:{ uniqueNumbers.Count} ");
    }
}