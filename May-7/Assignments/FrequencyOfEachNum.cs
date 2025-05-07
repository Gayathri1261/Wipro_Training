// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a numbers seperated by spaces:");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        Dictionary<int,int>freq = new Dictionary<int,int>();
        foreach(string part in parts)
        {
            int num = int.Parse(part);
            if (freq.ContainsKey(num))
                freq[num]++;
            else
                freq[num] = 1;
        }
        foreach(var item in freq)
        {
            Console.WriteLine($"{item.Key} appears {item.Value}" + (item.Value ==1 ? "time":"times"));
        }
    }
}