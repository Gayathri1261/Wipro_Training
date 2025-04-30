//Search for an element(Linear search)
//->Search for a given number in an array and print its index if found,else print "Not found".
//Ex.[3,5,7,8,2,9,10]
//Inpu:7
//Output:2


using System;

public class LinearSearch
{
    static void Main()
    {
    int[] numbers={ 3, 5, 7, 8, 2, 9, 10};
    Console.Write("Enter a number to search: ");
    int target=Convert.ToInt32(Console.ReadLine());
    for(int i=0;i<numbers.Length;i++)
    {
        if(numbers[i]==target)
        {
            Console.WriteLine($"Output:{i}");
            return;
        }
    }
    Console.WriteLine("Not Found");
    
    }
}