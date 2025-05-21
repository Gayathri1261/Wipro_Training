using System;
using System.Collections.Generic;

class FirstNonRepeatingCharacter
{
    static char FindFirstNonRepeatingChar(string input)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }

        foreach (char c in input)
        {
            if (charCount[c] == 1)
                return c;
        }

        return '\0'; 
    }

    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        char result = FindFirstNonRepeatingChar(input);

        if (result != '\0')
            Console.WriteLine($"First non-repeating character: {result}");
        else
            Console.WriteLine("No non-repeating character found.");
    }
}
