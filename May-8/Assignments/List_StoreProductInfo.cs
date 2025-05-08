using System;
using System.Collections;

class Product
{
    public int ID {  get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}
class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();

        //Add 5 products
        products.Add(new Product { ID = 1, Name = "Laptop", Price = 800.00 });
        products.Add(new Product { ID = 2, Name = "SmartPhone", Price = 600.00 });
        products.Add(new Product { ID = 3, Name = "Tablet", Price = 300.00 });
        products.Add(new Product { ID = 4, Name = "Monitor", Price = 200.00 });
        products.Add(new Product { ID = 5, Name = "Headphones", Price = 150 });

        //Sort by price in descending order
        products = products.OrderByDescending(p => p.Price).ToList();

        //Print all products after sorting
        Console.WriteLine("Products sorted by price(high to low):");
        foreach (var p in products)
        {
            Console.WriteLine($"ID:{p.ID},Name:{p.Name},Price:{p.Price}");

           
        }
        //print the product with the highest price
        var mostExpensive = products.First();
        Console.WriteLine($"\nProduct will highest price : {mostExpensive.Price}");
    }
       
}