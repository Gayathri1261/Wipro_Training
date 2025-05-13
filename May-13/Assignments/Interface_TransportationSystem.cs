using System;

namespace TransportationSystem
{
    
    public interface ITransport
    {
        void Start();
        void Stop();
    }
    public class Bus : ITransport
    {
        public void Start()
        {
            Console.WriteLine("Bus is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Bus is stopping");
        }
    }
    public class Train : ITransport
    {
        public void Start()
        {
            Console.WriteLine("Train is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Train is stopping");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ITransport transport = new Bus();
            transport.Start();
            transport.Stop();

            transport = new Train();
            transport.Start();
            transport.Stop();

            Console.ReadLine(); 
        }
    }
}