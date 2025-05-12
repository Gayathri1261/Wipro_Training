interface ICalculator
{
    int Add(int a, int b);
    int Subtract(int a, int b);
    int Multiply(int a, int b);
    double Divide(int a, int b);
}

//  Implement the Interface in SimpleCalculator
class SimpleCalculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Subtract(int a, int b)
    {
        return a - b;
    }
    public int Multiply(int a, int b)
    {
        return a * b;
    }
    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN; // Return "Not a Number"
        }
        return (double)a / b;
    }
}

// Main Method to Test the Calculator
class Program
{
    static void Main(string[] args)
    {
        // Create SimpleCalculator object
        SimpleCalculator calc = new SimpleCalculator();
        Console.WriteLine("Add(10, 5) = " + calc.Add(10, 5));
        Console.WriteLine("Subtract(10, 5) = " + calc.Subtract(10, 5));
        Console.WriteLine("Multiply(10, 5) = " + calc.Multiply(10, 5));
        Console.WriteLine("Divide(10, 5) = " + calc.Divide(10, 5));
        Console.WriteLine("Divide(10, 0) = " + calc.Divide(10, 0));
    }
}