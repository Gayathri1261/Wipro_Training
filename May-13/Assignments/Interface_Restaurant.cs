using System;

    public interface IOrder
    {
        void PlaceOrder(string item);
        void CancelOrder(string item);
    }

    public class DineInOrder : IOrder
    {
        public void PlaceOrder(string item)
        {
            Console.WriteLine($"Placing dine-in order for {item}");
        }

        public void CancelOrder(string item)
        {
            Console.WriteLine($"Canceling dine-in order for {item}");
        }
    }

    public class TakeawayOrder : IOrder
    {
        public void PlaceOrder(string item)
        {
            Console.WriteLine($"Placing takeaway order for {item}");
        }

        public void CancelOrder(string item)
        {
            Console.WriteLine($"Canceling takeaway order for {item}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IOrder order = new DineInOrder();
            order.PlaceOrder("Pizza");
            order.CancelOrder("Pizza");

            order = new TakeawayOrder();
            order.PlaceOrder("Burger");
            order.CancelOrder("Burger");

            Console.ReadLine();
        }
    }