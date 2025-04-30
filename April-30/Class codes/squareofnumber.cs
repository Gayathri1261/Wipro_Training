//Square of a given number
using System;

public class square
{
    static int Square(int number)
    {
        return number*number;
    }
    static void Main()
    {
        int result=Square(5);
        Console.WriteLine("Square is: "+ result);
    }
}