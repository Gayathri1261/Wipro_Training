using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 5, 8, 2, 5, 7, 2, 9, 1, 8, 3, 4, 7 };

        var duplicates = numbers
            .GroupBy(n => n)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key);
        Console.WriteLine("Duplicate numbers:");
        foreach (var num in duplicates)
        {
            Console.WriteLine(num);
        }
    }
}

