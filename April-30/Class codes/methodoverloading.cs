//Method Overloading
//Static overloading-when the process done in compile time


using System;

public class square
{
   static int Add(int a,int b)
   {
       return a+b;
   }
      static int Sub(int a,int b)
   {
       return a-b;
   }
      static int Mul(int a,int b)
   {
       return a*b;
   }
   static double Add(double a,double b)
   {
       return a+b;
   }

   static double Sub(double a,double b)
   {
       return a-b;
   }
   static double Mul(double a,double b)
   {
       return a*b;
   }
   static void Main()
   {
       Console.WriteLine("Int Add: " + Add(3,4));
       Console.WriteLine("Int Sub: " + Sub(3,4));
       Console.WriteLine("Int Mul: " + Mul(3,4));
       //7
       Console.WriteLine("Double Add: " + Add(2.5,4.3));
       Console.WriteLine("Double Sub: " + Sub(2.5,4.3));
       Console.WriteLine("Double Mul: " + Mul(2.5,4.3));
       //6.8
   }
}

