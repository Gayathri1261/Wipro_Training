//Lambda expression-no return statements, no braces

//Ternary operation- equation ? Condition1:condition 2….if eq satisfies executes condition 1 ,if eq not satisfied the condition 2 is executed

using System;

public class square
{
   static int Add(int a,int b)=> a+b; //no return statements, no braces
   static int Sub(int a,int b)=> a-b;
   static int Mul(int a,int b)=> a*b;
   static double Divide(int a,int b)=> (b==0) ? 0 : (double)a/b;
   
   static void Main()
   {
       Console.WriteLine("Add: " + Add(10,5));
       Console.WriteLine("Sub: " + Sub(10,5));
       Console.WriteLine("Mul: " + Mul(10,5));
       Console.WriteLine("Div: " + Divide(10,5));
   }
   
}

