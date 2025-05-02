using System;

class Program
{
    
    static int Factorial(int n)
    {
        if (n == 0 || n == 1) 
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1); 
        }
    }

    static void Main()
    {
        
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        
        int[] arr = new int[n];

        
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        
        int lastElement = arr[arr.Length - 1];

       
        int result = Factorial(lastElement);
        Console.WriteLine($"Factorial of {lastElement} is: {result}");
    }
}
