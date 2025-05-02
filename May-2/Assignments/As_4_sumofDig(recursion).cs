using System;

class Program
{
    static int SumArray(int[] arr, int index)
    {
        if (index == arr.Length) 
        {
            return 0;
        }
        else
        {
            
            Console.Write(arr[index] + " ");
            return arr[index] + SumArray(arr, index + 1); 
        }
    }

    static void Main()
    {
        
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

        
        Console.Write("Elements in the array: ");
        int result = SumArray(arr, 0);

        
        Console.WriteLine($"\nSum of elements in the array is: {result}");
    }
}
