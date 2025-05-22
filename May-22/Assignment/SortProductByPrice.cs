using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200 },
            new Product { Id = 2, Name = "Mouse", Price = 25 },
            new Product { Id = 3, Name = "Keyboard", Price = 75 },
            new Product { Id = 4, Name = "Monitor", Price = 300 },
            new Product { Id = 5, Name = "Smartphone", Price = 900 },
            new Product { Id = 6, Name = "Headphones", Price = 150 }
        };
        var sortedProducts = products.OrderByDescending(p => p.Price);
        Console.WriteLine("Products sorted by price (descending):");
        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.Name}, Price: {product.Price:C}");
        }
    }
}
