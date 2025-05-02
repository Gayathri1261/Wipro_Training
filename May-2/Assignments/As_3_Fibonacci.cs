using System;

class Program
{
    // Recursive function to calculate Fibonacci number
    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }

    static void Main()
    {
        
        Console.Write("Enter the position for Fibonacci sequence: ");
        int n = int.Parse(Console.ReadLine());

        
        Console.WriteLine($"Fibonacci numbers up to position {n}:");
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(Fibonacci(i));
        }
    }
}
