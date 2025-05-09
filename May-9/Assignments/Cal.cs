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

        //Substraction
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public int Sub(int a, int b, int c)
        {
            return a - b - c;
        }

        //Multiplication

        public int Mul(int a, int b)
        {
            return a * b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public int Mul(int a, int b, int c)
        {
            return a * b * c;
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

        //Substraction
        Console.WriteLine("Substraction:");
        Console.WriteLine("2 - 3 = " + calc.Sub(2, 3));
        Console.WriteLine("2.5 - 3.7 = " + calc.Sub(2.5, 3.7));
        Console.WriteLine("1 - 2 - 3 = " + calc.Sub(1, 2, 3));

        //Multiplication
        Console.WriteLine("Multiplication:");
        Console.WriteLine("2 * 3 = " + calc.Mul(2, 3));
        Console.WriteLine("2.5 * 3.7 = " + calc.Mul(2.5, 3.7));
        Console.WriteLine("1*2*3 = " + calc.Mul(1, 2, 3));
    }
}
