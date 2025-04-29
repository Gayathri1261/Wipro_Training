// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    //Method for Addition
    static int Add(int a,int b)
    {
        return a+b;
    }
    //Method for Substraction
    static int Sub(int a,int b)
    {
        return a-b;
    }
    //Method for Multiplication
    static int Mul(int a,int b)
    {
        return a*b;
    }
    //Method for Division
    static int Div(int a,int b)
    {
        return a/b;
    }
    static void Main()
    {
        int num1=20;
        int num2=10;
        Console.WriteLine("Addition: "+ Add(num1,num2));
        Console.WriteLine("Substraction "+ Sub(num1,num2));
        Console.WriteLine("Multiplication: "+ Mul(num1,num2));
        Console.WriteLine("Division: "+ Div(num1,num2));
    }
}