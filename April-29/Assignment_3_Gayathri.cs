using System;

class Tables
{
    static void Main(string[] args)
    {
         Console.WriteLine("Enter a number: ");
         int number=Convert.ToInt32(Console.ReadLine());
             for(int i=1;i<=10;i++)
             {
            Console.WriteLine(number + "x" + i + "=" + (number*i));
             }
    }
}