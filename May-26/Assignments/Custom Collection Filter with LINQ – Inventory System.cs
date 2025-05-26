using System;
using System.Collections.Generic;
using System.Linq;

public class Item
{
    public string Name { get; set; }
    public string Type { get; set; } // e.g., "Electronics", "Clothing", "Grocery"
    public int Stock { get; set; }
    public decimal Price { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Item> inventory = new List<Item>
        {
            new Item { Name = "Laptop", Type = "Electronics", Stock = 5, Price = 60000 },
            new Item { Name = "Smartphone", Type = "Electronics", Stock = 2, Price = 30000 },
            new Item { Name = "TV", Type = "Electronics", Stock = 1, Price = 45000 },
            new Item { Name = "Shirt", Type = "Clothing", Stock = 10, Price = 1200 },
            new Item { Name = "Jeans", Type = "Clothing", Stock = 3, Price = 2000 },
            new Item { Name = "Jacket", Type = "Clothing", Stock = 0, Price = 3500 },
            new Item { Name = "Rice Bag", Type = "Grocery", Stock = 15, Price = 1000 },
            new Item { Name = "Sugar", Type = "Grocery", Stock = 6, Price = 450 },
            new Item { Name = "Milk", Type = "Grocery", Stock = 20, Price = 60 },
            new Item { Name = "Shoes", Type = "Clothing", Stock = 4, Price = 2500 },
            new Item { Name = "Tablet", Type = "Electronics", Stock = 2, Price = 20000 },
            new Item { Name = "Watch", Type = "Electronics", Stock = 6, Price = 8000 },
            new Item { Name = "Oil", Type = "Grocery", Stock = 5, Price = 150 },
            new Item { Name = "Bread", Type = "Grocery", Stock = 0, Price = 50 },
            new Item { Name = "T-shirt", Type = "Clothing", Stock = 8, Price = 900 }
        };

        var lowStockItems = inventory.Where(i => i.Stock <= 5);
        Console.WriteLine(" Low Stock Items (<= 5):");
        foreach (var item in lowStockItems)
        {
            Console.WriteLine($"{item.Name} - {item.Type} - Stock: {item.Stock}");
        }

        var groupedByType = inventory.GroupBy(i => i.Type);
        Console.WriteLine("\n Items Grouped by Type:");
        foreach (var group in groupedByType)
        {
            Console.WriteLine($"\n{group.Key}:");
            foreach (var item in group)
            {
                Console.WriteLine($"  {item.Name} - ₹{item.Price} - Stock: {item.Stock}");
            }
        }

        Console.WriteLine("\n Highest Priced Item in Each Type:");
        foreach (var group in groupedByType)
        {
            var mostExpensive = group.OrderByDescending(i => i.Price).First();
            Console.WriteLine($"{group.Key}: {mostExpensive.Name} - ₹{mostExpensive.Price}");
        }
    }
}