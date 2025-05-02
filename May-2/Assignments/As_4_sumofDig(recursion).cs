using System;

class Program
{
    static int SumArray(int[] arr, int index)
    {
        if (index == arr.Length) // when index reaches to array length
        {
            return 0;    //It stops recursion returning 0
        }
        else
        {
            
            Console.Write(arr[index] + " "); //prints the current element
            return arr[index] + SumArray(arr, index + 1); //recursively calls SumArray with the next index. Adds the current element to the result of the recursive call, which gives the running sum.
        }
    }

    static void Main()
    {
        
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

        
        Console.Write("Elements in the array: ");
        int result = SumArray(arr, 0); //calls the SumArray starting from index 0.
                                       // It prints each element and returns the total sum, which is stored in result.

        
        Console.WriteLine($"\nSum of elements in the array is: {result}"); After all elements printed,it prints the sum.
    }
}
