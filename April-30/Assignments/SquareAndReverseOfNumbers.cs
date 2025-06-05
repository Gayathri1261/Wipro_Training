//square and reverse the numbers

using System;

public class square
{
    static void PrintArray(int[] arr)
    
    {
       for (int i = arr.Length - 1; i >= 0; i--)
        {
            int squared = arr[i] * arr[i];
            Console.WriteLine($"Element {arr.Length - i}: {squared}");
        }
    }
    static void Main()
    {
        int[] numbers = {10,20,30,40,50};
        PrintArray(numbers);
    }
}