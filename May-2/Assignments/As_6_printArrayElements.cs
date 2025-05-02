using System;

class Program
{
    static void PrintArray(int[] arr, int index)
    {
        if (index == arr.Length) 
        {
            return;
        }
        else
        {
            Console.Write(arr[index] + " ");
            
            PrintArray(arr, index + 1);
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

        Console.Write("Array elements: ");
        PrintArray(arr, 0); 
        Console.WriteLine(); 
    }
}
