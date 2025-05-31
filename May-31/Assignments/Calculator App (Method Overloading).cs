using System;

class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static float Add(float a, float b) => a + b;
    public static double Add(double a, double b) => a + b;

    public static int Subtract(int a, int b) => a - b;
    public static float Subtract(float a, float b) => a - b;
    public static double Subtract(double a, double b) => a - b;

    public static int Multiply(int a, int b) => a * b;
    public static float Multiply(float a, float b) => a * b;
    public static double Multiply(double a, double b) => a * b;
}

class Program
{
    static void Main()
    {
        Console.WriteLine(" Calculator App");
        Console.WriteLine("Choose operation: add / subtract / multiply");
        string operation = Console.ReadLine().ToLower();

        Console.WriteLine("Choose datatype: int / float / double");
        string type = Console.ReadLine().ToLower();

        Console.Write("Enter first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter second number: ");
        string input2 = Console.ReadLine();

        try
        {
            switch (type)
            {
                case "int":
                    int int1 = int.Parse(input1);
                    int int2 = int.Parse(input2);
                    Console.WriteLine("Result: " + CallIntOperation(operation, int1, int2));
                    break;

                case "float":
                    float float1 = float.Parse(input1);
                    float float2 = float.Parse(input2);
                    Console.WriteLine("Result: " + CallFloatOperation(operation, float1, float2));
                    break;

                case "double":
                    double double1 = double.Parse(input1);
                    double double2 = double.Parse(input2);
                    Console.WriteLine("Result: " + CallDoubleOperation(operation, double1, double2));
                    break;

                default:
                    Console.WriteLine("Invalid type.");
                    break;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format.");
        }
    }

    static int CallIntOperation(string op, int a, int b)
    {
        return op switch
        {
            "add" => Calculator.Add(a, b),
            "subtract" => Calculator.Subtract(a, b),
            "multiply" => Calculator.Multiply(a, b),
            _ => throw new Exception("Invalid operation")
        };
    }

    static float CallFloatOperation(string op, float a, float b)
    {
        return op switch
        {
            "add" => Calculator.Add(a, b),
            "subtract" => Calculator.Subtract(a, b),
            "multiply" => Calculator.Multiply(a, b),
            _ => throw new Exception("Invalid operation")
        };
    }

    static double CallDoubleOperation(string op, double a, double b)
    {
        return op switch
        {
            "add" => Calculator.Add(a, b),
            "subtract" => Calculator.Subtract(a, b),
            "multiply" => Calculator.Multiply(a, b),
            _ => throw new Exception("Invalid operation")
        };
    }
}
