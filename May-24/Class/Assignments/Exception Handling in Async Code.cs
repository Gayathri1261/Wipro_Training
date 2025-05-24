using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task t1 = RiskyTaskAsync("Task 1", false);
        Task t2 = RiskyTaskAsync("Task 2", true);  
        Task t3 = RiskyTaskAsync("Task 3", false);

        try
        {
            await Task.WhenAll(t1, t2, t3);
        }
        catch (Exception)
        {
            Console.WriteLine("One or more tasks failed.");

            if (t1.IsFaulted)
                Console.WriteLine("Task 1 failed: " + t1.Exception?.InnerException?.Message);
            if (t2.IsFaulted)
                Console.WriteLine("Task 2 failed: " + t2.Exception?.InnerException?.Message);
            if (t3.IsFaulted)
                Console.WriteLine("Task 3 failed: " + t3.Exception?.InnerException?.Message);
        }
    }
    static async Task RiskyTaskAsync(string name, bool shouldFail)
    {
        Console.WriteLine($"{name} started.");
        await Task.Delay(1000);

        if (shouldFail)
        {
            throw new Exception($"{name} encountered an error!");
        }

        Console.WriteLine($"{name} completed successfully.");
    }
}
