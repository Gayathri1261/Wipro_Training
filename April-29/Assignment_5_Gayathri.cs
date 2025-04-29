// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

class Tables
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter day from 1 to 7: ");
        int day=Convert.ToInt32(Console.ReadLine());
        if(day==1)
        {
            Console.WriteLine("Sunday");
        }
        else if(day==2)
        {
            Console.WriteLine("Monday");
        }
        else if(day==3)
        {
            Console.WriteLine("Tuesday");
        }
        else if(day==4)
        {
            Console.WriteLine("Wednesday");
        }
        else if(day==5)
        {
            Console.WriteLine("Thursday");
        }
        else if(day==6)
        {
            Console.WriteLine("Friday");
        }
        else if(day==7)
        {
            Console.WriteLine("Saturday");
        }
        else
        {
            Console.WriteLine("Please a valid number from 1 to 7");
        }
    }
}

