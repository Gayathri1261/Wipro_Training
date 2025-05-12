interface IPayment
{
    void ProcessPayment(decimal amount);

}

//Implementing the interface in CreditCardPayment

class CreditCardPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of Rs.{amount}");
    }
}

//Implementing the interface in PayPalPayment
class PayPalPayment : IPayment
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of Rs.{amount}");
   }
}
class Program
{
    static void Main()
    {
        //using the interface as a reference
        IPayment payment;

        //credit card payment
        payment = new PayPalPayment();
        payment.ProcessPayment(1500.50m);

        //PayPal payment
        payment = new PayPalPayment();
        payment.ProcessPayment(2500.75m);
    }
}