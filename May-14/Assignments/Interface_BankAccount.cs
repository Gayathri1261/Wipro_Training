using System;

public interface IBankAccount
{
    void Deposit(double amount);
    void Withdraw(double amount);
    void CheckBalance();
}
public class SavingsAccount : IBankAccount
{
    private double balance = 0;

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount:C} into Savings Account.");
    }
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew {amount:C} from Savings Account.");
        }
        else
        {
            Console.WriteLine("Insufficient funds in Savings Account.");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Savings Account Balance: {balance:C}");
    }
}
public class CurrentAccount : IBankAccount
{
    private double balance = 0;

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited {amount:C} into Current Account.");
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew {amount:C} from Current Account.");
        }
        else
        {
            Console.WriteLine("Insufficient funds in Current Account.");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current Account Balance: {balance:C}");
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        IBankAccount savings = new SavingsAccount();
        savings.Deposit(1000);
        savings.Withdraw(300);
        savings.CheckBalance();

        Console.WriteLine();
        IBankAccount current = new CurrentAccount();
        current.Deposit(5000);
        current.Withdraw(6000); 
        current.Withdraw(2000);
        current.CheckBalance();
    }
}