class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 10, 23, 45, 66, 78, 91, 34, 57, 88, 100 };

        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

        Console.WriteLine("Even Numbers:");
        foreach (int num in evenNumbers)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine("\n\nOdd Numbers:");
        foreach (int num in oddNumbers)
        {
            Console.Write(num + " ");
        }
    }
}
