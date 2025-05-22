using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Step 1: Input a sentence
        string sentence = "C# is great and C# is fun";

        // Step 2: Split it into words (ignore case, remove punctuation if needed)
        var words = sentence
            .Split(new[] { ' ', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(word => word.ToLower());  // Make case-insensitive

        // Step 3: Use LINQ group by and count
        var wordGroups = words
            .GroupBy(w => w)
            .Select(g => new { Word = g.Key, Count = g.Count() });

        // Step 4: Print the word frequencies
        Console.WriteLine("Word Frequency:");
        foreach (var group in wordGroups)
        {
            Console.WriteLine($"{group.Word}: {group.Count}");
        }
    }
}
