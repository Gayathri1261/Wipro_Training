using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a paragraph:");
        string paragraph = Console.ReadLine();

        string cleanedText = Regex.Replace(paragraph.ToLower(), @"[^\w\s]", "");

        string[] words = cleanedText.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        var wordFrequency = words
            .GroupBy(w => w)
            .ToDictionary(g => g.Key, g => g.Count());

        Console.WriteLine("\n Word Frequency:");
        foreach (var pair in wordFrequency.OrderByDescending(p => p.Value))
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
        int vowelCount = 0;
        int consonantCount = 0;
        foreach (char c in cleanedText)
        {
            if (char.IsLetter(c))
            {
                if ("aeiou".Contains(c))
                    vowelCount++;
                else
                    consonantCount++;
            }
        }

        Console.WriteLine($"\n Vowels: {vowelCount}");
        Console.WriteLine($" Consonants: {consonantCount}");

        string longestWord = words.OrderByDescending(w => w.Length).FirstOrDefault();
        string shortestWord = words.OrderBy(w => w.Length).FirstOrDefault();

        Console.WriteLine($"\n Longest Word: {longestWord}");
        Console.WriteLine($" Shortest Word: {shortestWord}");
    }
}
