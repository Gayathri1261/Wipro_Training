class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        int count = CountWords(sentence);
        Console.WriteLine(count + " words");
    }
    static int CountWords(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}