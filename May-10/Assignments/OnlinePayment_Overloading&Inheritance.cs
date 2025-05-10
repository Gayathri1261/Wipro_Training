using System;

// Base class
class Payment
{
    public decimal amount;
    public string currency;

    // Method to process payment using existing fields
    public virtual void ProcessPayment()
    {
        Console.WriteLine("Processing payment of " + amount + " " + currency);
    }

    // Overloaded method: accepts amount only
    public void ProcessPayment(decimal amt)
    {
        amount = amt;
        currency = "USD";
        Console.WriteLine("Processing payment of " + amount + " " + currency);
    }

    // Overloaded method: accepts amount and currency
    public void ProcessPayment(decimal amt, string curr)
    {
        amount = amt;
        currency = curr;
        Console.WriteLine("Processing payment of " + amount + " " + currency);
    }
}

// Derived class: Credit Card Payment
class CreditCardPayment : Payment
{
    public string cardNumber;

    public override void ProcessPayment()
    {
        base.ProcessPayment();
        Console.WriteLine("Paid using Credit Card: " + cardNumber);
    }
}

// Derived class: PayPal Payment
class PayPalPayment : Payment
{
    public string emailAddress;

    public override void ProcessPayment()
    {
        base.ProcessPayment();
        Console.WriteLine("Paid using PayPal Account: " + emailAddress);
    }
}

class Program
{
    static void Main()
    {
        // Credit card payment
        CreditCardPayment ccPayment = new CreditCardPayment();
        ccPayment.cardNumber = "1234-5678-9012-3456";
        ccPayment.ProcessPayment(100.00m); // Overloaded method
        ccPayment.ProcessPayment();        // Override method with details
        Console.WriteLine();

        // PayPal payment
        PayPalPayment paypalPayment = new PayPalPayment();
        paypalPayment.emailAddress = "user@example.com";
        paypalPayment.ProcessPayment(250.00m, "EUR"); // Overloaded method
        paypalPayment.ProcessPayment();               // Override method with details
    }
}