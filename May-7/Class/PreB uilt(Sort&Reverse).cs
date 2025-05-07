using System;
using System.Collections;
using System.Globalization;

class Program
{
    static void Main()
    {
        ArrayList numbers = new ArrayList() { 4, 1, 8, 3 };
        numbers.Sort();
        Console.WriteLine("Sorted:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);  //output:1,3,4,8
        }
        numbers.Reverse();
        Console.WriteLine("Reversed:");
        foreach (var num in numbers)
        {
            Console.WriteLine(num);//output:8,4,3,1
        }
    }
}