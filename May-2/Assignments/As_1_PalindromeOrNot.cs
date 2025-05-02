using System;

class Program
{
    // Method using a for loop to check palindrome
    static bool IsPalindrome(string word)
    {
        for (int i = 0; i < word.Length / 2; i++) //  word.Length / 2,we only check halfway
        {
            if (word[i] != word[word.Length - 1 - i]) //i = 0
                                                      //  word[0] = 'm'
                                                      //  word[5 - 1 - 0] = word[4] = 'm'
                                                       //  'm' == 'm' → ok
                return false;
        }
        return true;
    }

    static void Main()
    {
        string[] inputs = { "racecar", "madam" };

        foreach (string word in inputs) //This loop goes through each word in the array.
        {
            if (IsPalindrome(word))
                Console.WriteLine($"'{word}' is a palindrome.");
            else
                Console.WriteLine($"'{word}' is not a palindrome.");
        }
    }
}
