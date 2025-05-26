using System;
using System.Collections.Generic;
using System.IO;

public class Transaction
{
    public DateTime Timestamp { get; set; }
    public string Type { get; set; } 
    public decimal Amount { get; set; }

    public override string ToString()
    {
        return $"{Timestamp},{Type},{Amount}";
    }

    public static Transaction FromString(string line)
    {
        var parts = line.Split(',');
        return new Transaction
        {
            Timestamp = DateTime.Parse(parts[0]),
            Type = parts[1],
            Amount = decimal.Parse(parts[2])
        };
    }
}

public class BankAccount
{
    public List<Transaction> Transactions { get; private set; } = new List<Transaction>();
    private const string FilePath = "transactions.txt";

    public void Deposit(decimal amount)
    {
        Transactions.Add(new Transaction
        {
            Timestamp = DateTime.Now,
            Type = "Deposit",
            Amount = amount
        });
        Console.WriteLine($"deposited ₹{amount}");
    }

    public void Withdraw(decimal amount)
    {
        Transactions.Add(new Transaction
        {
            Timestamp = DateTime.Now,
            Type = "Withdraw",
            Amount = amount
        });
        Console.WriteLine($"Withdrew ₹{amount}");
    }

    public decimal GetBalance()
    {
        decimal balance = 0;
        foreach (var t in Transactions)
        {
            if (t.Type == "Deposit")
                balance += t.Amount;
            else if (t.Type == "Withdraw")
                balance -= t.Amount;
        }
        return balance;
    }

    public void SaveTransactions()
    {
        File.WriteAllLines(FilePath, Transactions.ConvertAll(t => t.ToString()));
    }

    public void LoadTransactions()
    {
        if (File.Exists(FilePath))
        {
            var lines = File.ReadAllLines(FilePath);
            foreach (var line in lines)
            {
                Transactions.Add(Transaction.FromString(line));
            }
        }
    }

    public void DisplaySummary()
    {
        Console.WriteLine("\n Transaction Summary:");
        foreach (var t in Transactions)
        {
            Console.WriteLine($"{t.Timestamp}: {t.Type} ₹{t.Amount}");
        }
        Console.WriteLine($" Current Balance: ₹{GetBalance()}\n");
    }
}

public class Program
{
    public static void Main()
    {
        BankAccount account = new BankAccount();
        account.LoadTransactions();
        account.DisplaySummary();

        account.Deposit(5000);
        account.Withdraw(1200);

        account.SaveTransactions();

        Console.WriteLine("\nTransactions saved successfully.");
    }
}
