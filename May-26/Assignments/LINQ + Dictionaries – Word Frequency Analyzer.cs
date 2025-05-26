using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string paragraph = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                             Lorem ipsum dolor sit amet, consectetur adipiscing elit. 
                             Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";

        char[] delimiters = { ' ', ',', '.', ';', ':', '-', '\n', '\r' };
        string[] words = paragraph
            .ToLower()
            .Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (frequency.ContainsKey(word))
                frequency[word]++;
            else
                frequency[word] = 1;
        }

        var top5 = frequency
            .OrderByDescending(kvp => kvp.Value)
            .Take(5);

        Console.WriteLine("Top 5 most frequent words:");
        foreach (var kvp in top5)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
