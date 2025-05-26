using System;
using System.Collections.Generic;

public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public abstract class PaymentGateway
{
    public string GatewayName { get; set; }

    public PaymentGateway(string name)
    {
        GatewayName = name;
    }

    public virtual bool Validate()
    {
        Console.WriteLine($"Validating {GatewayName} gateway...");
        return true;
    }
}
public class Razorpay : PaymentGateway, IPaymentProcessor
{
    public Razorpay() : base("Razorpay") {}

    public void ProcessPayment(decimal amount)
    {
        if (Validate())
        {
            Console.WriteLine($"Processing ₹{amount} through {GatewayName}");
        }
    }
}
public class PayPal : PaymentGateway, IPaymentProcessor
{
    public PayPal() : base("PayPal") {}

    public void ProcessPayment(decimal amount)
    {
        if (Validate())
        {
            Console.WriteLine($"Processing ${amount} through {GatewayName}");
        }
    }
}
public class Stripe : PaymentGateway, IPaymentProcessor
{
    public Stripe() : base("Stripe") {}

    public void ProcessPayment(decimal amount)
    {
        if (Validate())
        {
            Console.WriteLine($"Processing ${amount} through {GatewayName}");
        }
    }
}
public class Program
{
    public static void Main()
    {
        List<IPaymentProcessor> paymentProcessors = new List<IPaymentProcessor>
        {
            new Razorpay(),
            new PayPal(),
            new Stripe()
        };

        decimal[] amounts = { 1500.50m, 200.00m, 899.99m };

        for (int i = 0; i < paymentProcessors.Count; i++)
        {
            paymentProcessors[i].ProcessPayment(amounts[i]);
        }
    }
}
