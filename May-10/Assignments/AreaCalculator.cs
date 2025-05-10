//3: Area Calculation
//Overload the Area () method for different shapes:
//Rectangle (length, breadth)
//Circle (radius)
//Triangle (base, height)
//Print the calculated areas.

using System;
class AreaCalculator
{
    
    public double Area(double length, double breadth)
    {
        return length * breadth;
    }

       public double Area(double radius)
    {
        return Math.PI * radius * radius;
    }

       public double Area(int baseLength, int height)
    {
        return 0.5 * baseLength * height;
    }
}

class Program
{
    static void Main()
    {
        AreaCalculator calc = new AreaCalculator();

               Console.WriteLine("Area of Rectangle:" + calc.Area(5.0, 3.0));

        Console.WriteLine("Area of Circle : " + calc.Area(4.0));

           Console.WriteLine("Area of Triangle : " + calc.Area(6, 2));
    }
}