// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Threading;

public class HelloWorld
{
    
    static bool pause=false;
    static bool stop = false;
    
    static void PrintNumbers()
    {
        for(int i=1;i<=100;i++)
        {
        Console.WriteLine($"Thread: {i}");
        Thread.Sleep(500);
        }
    }
    static void DoWork()
    {
        while(!stop)
        {
            if(pause)
            {
                Console.WriteLine("Thread paused...");
                Thread.Sleep(500);
                continue;
            }
            Console.WriteLine("Thread is working...");
                Thread.Sleep(1000);
        }
        Console.WriteLine("Thread has stopped...");
               
    }
    static void Main()
    {
        Thread myThread = new Thread(PrintNumbers);
        myThread.Start();
        
        Thread worker=new Thread(DoWork);
        Console.WriteLine("Initial Thread State:" + worker.ThreadState);
        worker.Start();
        Thread.Sleep(3000);
        pause=true;
        Console.WriteLine("Paused Thread state:" + worker.ThreadState);
        
        Thread.Sleep(3000);
        pause=false;
        Console.WriteLine("Resuming work...");
        
        Thread.Sleep(3000);
        stop=true;
        Console.WriteLine("Stopping Thread...");
        
        worker.Join(); //wait for thread to finish
        Console.WriteLine("Final Thread State:" + worker.ThreadState);
    }
}
