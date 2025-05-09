using System;
using System.Runtime.CompilerServices;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a Shape.");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Dreawing a circle.");
    }
}

class Program
{
    static void Main()
    {
        Shape shapeRef = new Circle();
        shapeRef.Draw();

 
    }
}