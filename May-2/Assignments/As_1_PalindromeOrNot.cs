using System;

class Program
{
    // Method using a for loop to check palindrome
    static bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
                return false;
        }
        return true;
    }

    static void Main()
    {
        string[] inputs = { "racecar", "madam" };

        foreach (string word in inputs)
        {
            if (IsPalindrome(word))
                Console.WriteLine($"'{word}' is a palindrome.");
            else
                Console.WriteLine($"'{word}' is not a palindrome.");
        }
    }
}
