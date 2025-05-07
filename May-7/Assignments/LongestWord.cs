// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static string GetLongestWord(string sentence)
    {
        string[] words = sentence.Split(' ');
        string longest = "";
        foreach(string word in words)
        {
            string cleanWord = word.Trim(new char[] {'.',',','!','?',';',':'});
            if(cleanWord.Length > longest.Length)
            {
                longest = cleanWord;
            }
        }
        return longest;
    }
    public static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();
        string longestWord=GetLongestWord(input);
        Console.WriteLine("Output: "+ longestWord);

    }
}