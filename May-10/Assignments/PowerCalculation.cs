//Task 2: Power Calculation
//Add methods to calculate power (x^y):
//Two integers (int base, int exponent)
//Two doubles (double base, double exponent)
//Print the result of 2^3 and 5.5*2.

using System;

class PowerCalculation
{
    public int Power(int basevalue,int exponent)
    {
        return (int)Math.Pow(basevalue,exponent);
    }
    public double Power(double basevalue,double exponent)
    {
        return Math.Pow(basevalue,exponent);
    }
}
class Program
{
    static void Main()
    {
        PowerCalculation PC =new PowerCalculation();
        Console.WriteLine("Power Calculation:");
        Console.WriteLine("2 ^ 3 = " + PC.Power(2, 3));
        Console.WriteLine("5.5 ^ 2 = " + PC.Power(5.5, 2));
    }
}