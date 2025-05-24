using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program2
    {
        static bool pause = false;
        static bool stop = false;

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
                Thread.Sleep(1000); //Simulate work
            }
            Console.WriteLine("Thread has stopped.");
        }
      /*  static void Main()
        {
            Thread worker = new Thread(DoWork);
            Console.WriteLine("Initial Thread State: " + worker.ThreadState);
            worker.Start();

            Thread.Sleep(3000);
            pause = true;
            Console.WriteLine("Paused Thread State: " + worker.ThreadState);

            Thread.Sleep(3000);
            pause = false;
            Console.WriteLine("Resuming work....");

            Thread.Sleep(3000);
            stop = true;
            Console.WriteLine("Stopping Thread...");

            worker.Join();  //wait for thread to finish
            Console.WriteLine("Final Thread State: " + worker.ThreadState);
        }*/
    }
}
