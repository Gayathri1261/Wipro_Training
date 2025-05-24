using System;
using System.Threading;

class Program
{
    static void PrintTask()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"PrintTask: {i}");
            Thread.Sleep(300); 
        }
        Console.WriteLine("PrintTask completed.");
    }
    static void ComputeTask()
    {
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }
        Thread.Sleep(100); 
        Console.WriteLine($"ComputeTask: Sum = {sum}");
        Console.WriteLine("ComputeTask completed.");
    }

    static void WaitTask()
    {
        Console.WriteLine("WaitTask: Waiting for 1 second...");
        Thread.Sleep(1000); 
        Console.WriteLine("WaitTask completed.");
    }
    static void Main()
    {
        Thread thread1 = new Thread(PrintTask);
        Thread thread2 = new Thread(ComputeTask);
        Thread thread3 = new Thread(WaitTask);

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("All tasks done.");
    }
}
