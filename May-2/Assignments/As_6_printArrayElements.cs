using System;

class Program
{
    static void PrintArray(int[] arr, int index)
    {
        if (index == arr.Length) // if index equal to arr.length,means it reached past the last element
        {
            return;              //so we stop recursion using return statement
        }
        else
        {
            Console.Write(arr[index] + " "); //first print the current element
            
            PrintArray(arr, index + 1); //call PrintArray() with the next index (index + 1) ,next element is processed in the next recursive call.
        }
    }
    static void Main()
    {
        
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());
        
        int[] arr = new int[n]; //Creates an integer array of size n.

        
        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < n; i++) //Iterates from 0 to n-1, taking n individual inputs from the user.
        {
            arr[i] = int.Parse(Console.ReadLine()); //Each input is stored in arr.
        }

        Console.Write("Array elements: ");
        PrintArray(arr, 0); // Calls PrintArray starting at index 0.
        Console.WriteLine(); //it add the new line for after printing all elements.
    }
}
