using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Creating a queue of strings
        Queue<string> customers = new Queue<string>();
        //Enqueue elements
        customers.Enqueue("Rajesh");
        customers.Enqueue("Priya");
        customers.Enqueue("Neha");


        Console.WriteLine("Serving customers:");
        while (customers.Count > 0)
        {
            Console.WriteLine("Serving: " + customers.Dequeue());
        }
    }
}