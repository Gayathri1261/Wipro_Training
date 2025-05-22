using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>
        {
            "Alice", "Ethan", "Olivia", "Brian", "Uma", "Chris", "Ian", "Zara", "Aaron", "Nina"
        };
        var vowels = new char[] { 'A', 'E', 'I', 'O', 'U' };
        var namesStartingWithVowel = names
            .Where(name => vowels.Contains(char.ToUpper(name[0])));
        Console.WriteLine("Names starting with a vowel:");
        foreach (var name in namesStartingWithVowel)
        {
            Console.WriteLine(name);
        }
    }
}

