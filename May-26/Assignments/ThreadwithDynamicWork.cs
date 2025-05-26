using System;
using System.Collections.Generic;
using System.Threading;

public class DynamicWorker
{
    private Queue<string> taskQueue = new Queue<string>();
    private object queueLock = new object();
    private bool stopRequested = false;

    public void Start()
    {
        Thread workerThread = new Thread(() => ProcessTasks());
        workerThread.Start();

        for (int i = 1; i <= 5; i++)
        {
            lock (queueLock)
            {
                taskQueue.Enqueue($"Task {i}");
                Console.WriteLine($"[Main] Enqueued Task {i}");
            }
            Thread.Sleep(500);  
        }

        while (true)
        {
            lock (queueLock)
            {
                if (taskQueue.Count == 0)
                {
                    stopRequested = true;
                    break;
                }
            }
            Thread.Sleep(100); 
        }

        workerThread.Join();
        Console.WriteLine("All tasks processed. Worker thread exited.");
    }

    private void ProcessTasks()
    {
        while (true)
        {
            string task = null;

            lock (queueLock)
            {
                if (taskQueue.Count > 0)
                {
                    task = taskQueue.Dequeue();
                }
                else if (stopRequested)
                {
                    return;
                }
            }

            if (task != null)
            {
                Console.WriteLine($"[Worker] Processing {task}");
                Thread.Sleep(1000); 
            }
            else
            {
                Thread.Sleep(100); 
            }
        }
    }
}
public class Program
{
    public static void Main()
    {
        DynamicWorker worker = new DynamicWorker();
        worker.Start();
    }
}
