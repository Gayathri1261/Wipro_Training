using System;
using System.Collections;

class Program
{
    static void Main()
    {
       //Create an arrayList of integers
       ArrayList numbers = new ArrayList();
        Random random = new Random();

        //Add 10 random numbers between 1 and 50
        for(int i=0;i<10;i++)
        {
            int randomNumber = random.Next(1,51); //1 to 50 inclusive
            numbers.Add(randomNumber);
        }
        //Display original list
        Console.WriteLine("Original list:");
        foreach(int num in numbers)
        { 
            Console.Write(num + " ");
        }
        Console.WriteLine();

        //sort the numbers

        numbers.Sort();

        //Show sorted numbers
        Console.WriteLine("Sorted numbers");
        foreach(int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        //Find max and min
        int min = (int)numbers[0];
        int max = (int)numbers[numbers.Count - 1];
        Console.WriteLine("Minimum: " + min);
        Console.WriteLine("Maximum:" + max);

        //Calculate average
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        double average=(double)total / numbers.Count;
        Console.WriteLine("Average: " + average.ToString("F2"));
    }
}