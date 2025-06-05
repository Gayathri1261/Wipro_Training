//Print squares of numbers until the square exceeds 100.
//Using for loop
using System;

class Program
{
    static void Main()
    {
        for (int i = 1; i * i <= 100; i++)
        {
            Console.WriteLine("Square of " + i + " is " + (i * i));
        }
    }
}
