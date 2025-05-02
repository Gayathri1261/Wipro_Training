using System;

class Program
{
    
    static int Factorial(int n)
    {
        if (n == 0 || n == 1) //if n=0/1 it stops the recursion
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1); //if n is more than 1 it will be multiplied
        }
    }

    static void Main()
    {
        
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        
        int[] arr = new int[n];  //creates an int arr of size n 

        
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine()); //after entering the elements stores each number in arr[i]
        }

        
        int lastElement = arr[arr.Length - 1]; //last element of the array

       
        int result = Factorial(lastElement);
        Console.WriteLine($"Factorial of {lastElement} is: {result}");
    }
}
