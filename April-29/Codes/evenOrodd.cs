
using System;

class HelloWorld
{
    static void Main(string[] args)
    {
         Console.WriteLine("Enter a number: ");
         int num=Convert.ToInt32(Console.ReadLine()); //Converts that string to an integer using Convert.ToInt32(...) so that you can perform arithmetic operations like checking if it's even or odd.
         if(num%2==0)
         {
             Console.WriteLine(num+ "iseven");
         }
         else
         {
             Console.WriteLine(num+"isodd");
         }
    }
}


