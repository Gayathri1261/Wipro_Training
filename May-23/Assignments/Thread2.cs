using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Thread2
{
    class Program
    {
        static void PrintMessage(object message)
        {
            string msg = (string)message; //Cast to correct type
            Console.WriteLine("Message: " + msg);
        }
       /* static void Main()
        {
            Thread thread = new Thread(new ParameterizedThreadStart(PrintMessage));
            thread.Start("Hello from the thread!");
        }*/
    }
}