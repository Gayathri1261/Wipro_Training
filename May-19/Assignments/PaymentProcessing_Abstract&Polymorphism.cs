using System;

public abstract class PaymentMethod
{
    public abstract void ProcessPayment(decimal amount);

    public virtual void ShowPaymentMethod()
    {
        Console.WriteLine("Payment Method: [Base Method]");
    }
}

public class CreditCardPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of ₹{amount}");
    }

    public override void ShowPaymentMethod()
    {
        Console.WriteLine("Payment Method: Credit Card");
    }
}

public class UPIPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing UPI payment of ₹{amount}");
    }

    public override void ShowPaymentMethod()
    {
        Console.WriteLine("Payment Method: UPI");
    }
}

public class Program
{
    public static void Main()
    {
      
        PaymentMethod creditCard = new CreditCardPayment();
        PaymentMethod upi = new UPIPayment();

        Console.WriteLine(" Credit Card Payment ");
        creditCard.ShowPaymentMethod();
        creditCard.ProcessPayment(1500.00m);

        Console.WriteLine("\n UPI Payment ");
        upi.ShowPaymentMethod();
        upi.ProcessPayment(750.50m);
    }
}