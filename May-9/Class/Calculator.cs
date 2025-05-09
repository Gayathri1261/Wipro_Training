using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Calculator
    {
        //Addition overloading
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        { 
            return a + b;
        }
        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }
    }
}

using System;
using System.Security.Cryptography;
using ConsoleApp1;
//using ConsoleApp1;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        //Addition
        Console.WriteLine("Addition:");
        Console.WriteLine("2 + 3 = " + calc.Add(2, 3));
        Console.WriteLine("2.5 + 3.7 = " + calc.Add(2.5, 3.7));
        Console.WriteLine("1 +2 +3 = " + calc.Add(1, 2, 3));
    }
}
