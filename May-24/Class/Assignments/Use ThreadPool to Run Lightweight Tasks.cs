using System;
using System.Threading;

public class Program
{
    static void ProcessItem(object item)
    {
        Console.WriteLine($"Processing item: {item}");
        Thread.Sleep(1000); 
        Console.WriteLine($"Finished processing item: {item}");
    }

    static void Main()
    {
        string[] items = { "Item1", "Item2", "Item3", "Item4", "Item5" };

        foreach (var item in items)
        {
            ThreadPool.QueueUserWorkItem(ProcessItem, item);
        }
        
        Thread.Sleep(3000);

        Console.WriteLine("All items have been queued.");
    }
}
