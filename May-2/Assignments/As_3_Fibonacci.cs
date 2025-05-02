using System;

class Program
{
    // Recursive function to calculate Fibonacci number
    static int Fibonacci(int n)
    {
        if (n <= 1)  //if n is 0,return 0    if n is 1, return 1  it prevents from infinite recursion
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);  //it returns the sum of previous 2 fibonacci numbers.
        }
    }

    static void Main()
    {
        
        Console.Write("Enter the position for Fibonacci sequence: ");
        int n = int.Parse(Console.ReadLine());

        
        Console.WriteLine($"Fibonacci numbers up to position {n}:");
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(Fibonacci(i)); //For each index i, the program calls the recursive Fibonacci(i) function and prints the result.


        }
    }
}
