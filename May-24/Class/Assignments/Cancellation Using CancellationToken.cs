using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        
        Task workTask = DoWorkAsync(cts.Token);

        await Task.Delay(2000);
        cts.Cancel();
        Console.WriteLine("Cancellation requested.");
        try
        {
            await workTask;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Task was cancelled.");
        }
    }
    static async Task DoWorkAsync(CancellationToken token)
    {
        Console.WriteLine("Work started.");

        for (int i = 0; i < 10; i++)
        {
            token.ThrowIfCancellationRequested();  // Check for cancellation
            await Task.Delay(1000);  // Simulate work
            Console.WriteLine($"Working... {i + 1}");
        }
        Console.WriteLine("Work completed.");
    }
}
