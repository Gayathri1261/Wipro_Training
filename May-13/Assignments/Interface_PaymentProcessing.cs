using System;

namespace PaymentProcessing
{
    public abstract class PaymentGateway
    {
        public abstract void ProcessPayment(double amount);
        public void ShowGatewayName()
        {
            Console.WriteLine("Processing payment through gateway");
        }
    }
    public class StripeGateway : PaymentGateway
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment through Stripe: ₹{amount}");
        }
    }
    public class PayPalGateway : PaymentGateway
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment through PayPal: ₹{amount}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PaymentGateway gateway = new StripeGateway();
            gateway.ShowGatewayName();
            gateway.ProcessPayment(2500.00);

            gateway = new PayPalGateway();
            gateway.ShowGatewayName();
            gateway.ProcessPayment(1500.50);

            Console.ReadLine(); 
        }
    }
}