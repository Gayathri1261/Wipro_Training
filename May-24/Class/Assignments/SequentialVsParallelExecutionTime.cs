using System;
using System.Diagnostics;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("=== Sequential Execution ===");
        Stopwatch stopwatch = Stopwatch.StartNew();

        await SimulateWorkAsync("Task 1", 1000);
        await SimulateWorkAsync("Task 2", 1000);
        await SimulateWorkAsync("Task 3", 1000);

        stopwatch.Stop();
        Console.WriteLine($"Sequential total time: {stopwatch.ElapsedMilliseconds} ms\n");

        Console.WriteLine("=== Parallel Execution ===");
        stopwatch.Restart();

        Task t1 = SimulateWorkAsync("Task 1", 1000);
        Task t2 = SimulateWorkAsync("Task 2", 1000);
        Task t3 = SimulateWorkAsync("Task 3", 1000);

        await Task.WhenAll(t1, t2, t3);

        stopwatch.Stop();
        Console.WriteLine($"Parallel total time: {stopwatch.ElapsedMilliseconds} ms");
    }

    static async Task SimulateWorkAsync(string name, int delay)
    {
        Console.WriteLine($"{name} started.");
        await Task.Delay(delay);
        Console.WriteLine($"{name} completed.");
    }
}
