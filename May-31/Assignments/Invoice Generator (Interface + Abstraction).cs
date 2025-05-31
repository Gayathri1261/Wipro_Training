using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

interface IPrintable
{
    void Print();
}

abstract class Invoice : IPrintable
{
    public List<Product> Products = new List<Product>();
    public abstract double CalculateTotal();

    public virtual void Print()
    {
        Console.WriteLine("\n Invoice:");
        foreach (var p in Products)
        {
            Console.WriteLine($"- {p.Name} : ₹{p.Price}");
        }

        Console.WriteLine($"Total: ₹{CalculateTotal():0.00}");
    }
}

class RetailInvoice : Invoice
{
    public override double CalculateTotal()
    {
        double subtotal = 0;
        foreach (var p in Products)
            subtotal += p.Price;

        double tax = subtotal * 0.10;
        double discount = subtotal * 0.05;

        return subtotal + tax - discount;
    }

    public override void Print()
    {
        Console.WriteLine("️ Retail Invoice");
        base.Print();
    }
}

class WholesaleInvoice : Invoice
{
    public override double CalculateTotal()
    {
        double subtotal = 0;
        foreach (var p in Products)
            subtotal += p.Price;

        double tax = subtotal * 0.05;
        double discount = subtotal * 0.10;

        return subtotal + tax - discount;
    }

    public override void Print()
    {
        Console.WriteLine(" Wholesale Invoice");
        base.Print();
    }
}

class Program
{
    static void Main()
    {
        var productList = new List<Product>
        {
            new Product { Name = "Pen", Price = 10 },
            new Product { Name = "Notebook", Price = 50 },
            new Product { Name = "Bag", Price = 500 }
        };

        RetailInvoice retail = new RetailInvoice();
        retail.Products.AddRange(productList);
        retail.Print();

        WholesaleInvoice wholesale = new WholesaleInvoice();
        wholesale.Products.AddRange(productList);
        wholesale.Print();
    }
}
