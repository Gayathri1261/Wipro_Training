using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1200 },
            new Product { Name = "Mouse", Price = 150 },
            new Product { Name = "Smartphone", Price = 800 },
            new Product { Name = "Keyboard", Price = 300 },
            new Product { Name = "Monitor", Price = 700 }
        };
        var expensiveProducts = products.Where(p => p.Price > 500);
        
        Console.WriteLine("Products with price > 500:");
        foreach (var product in expensiveProducts)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
        }
    }
}
