using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Task[] tasks = new Task[5];

        tasks[0] = Task.Run(() => SimulateTask(1, false));
        tasks[1] = Task.Run(() => SimulateTask(2, true));  
        tasks[2] = Task.Run(() => SimulateTask(3, false));
        tasks[3] = Task.Run(() => SimulateTask(4, true));  
        tasks[4] = Task.Run(() => SimulateTask(5, false));

        try
        {
            await Task.WhenAll(tasks);
        }
        catch (AggregateException ae)
        {
            Console.WriteLine("One or more tasks failed:");

            foreach (var ex in ae.Flatten().InnerExceptions)
            {
                Console.WriteLine($" - {ex.Message}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("All tasks completed (with or without errors).");
        }
    }

    static void SimulateTask(int taskNumber, bool shouldThrow)
    {
        Console.WriteLine($"Task {taskNumber} started.");

        if (shouldThrow)
        {
            throw new Exception($"Task {taskNumber} failed due to some error.");
        }

        Task.Delay(1000).Wait();

        Console.WriteLine($"Task {taskNumber} completed successfully.");
    }
}
