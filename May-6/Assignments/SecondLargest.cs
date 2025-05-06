class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a numbers seperated by spaces:");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');
        int[] numbers = new int[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            numbers[i] = int.Parse(parts[i]);
        }
        Array.Sort(numbers);
        int secondLargest=numbers[numbers.Length - 2];
        Console.WriteLine("Second Largest:" + secondLargest);

    }
}