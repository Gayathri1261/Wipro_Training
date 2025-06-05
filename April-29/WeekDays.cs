
using System;

class Tables
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number(1 to 7): ");
        int dayNumber=Convert.ToInt32(Console.ReadLine());
        if(dayNumber==1)
        {
            Console.WriteLine("Sunday");
        }
        else if(dayNumber==2)
        {
            Console.WriteLine("Monday");
        }
        else if(dayNumber==3)
        {
            Console.WriteLine("Tuesday");
        }
        else if(dayNumber==4)
        {
            Console.WriteLine("Wednesday");
        }
        else if(dayNumber==5)
        {
            Console.WriteLine("Thursday");
        }
        else if(dayNumber==6)
        {
            Console.WriteLine("Friday");
        }
        else if(dayNumber==7)
        {
            Console.WriteLine("Saturday");
        }
        else
        {
            Console.WriteLine("Please a valid number from 1 to 7");
        }
    }
}

