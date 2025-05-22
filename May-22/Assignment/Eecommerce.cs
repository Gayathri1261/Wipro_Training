using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int Id;
    public string Name;
    public decimal Price;

    public Product(int id, string name, decimal price)
    {
        Id = id;
        Name = name;
        Price = price;
    }
}
class CartItem
{
    public Product Product;
    public int Quantity;

    public CartItem(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public decimal GetTotalPrice()
    {
        return Product.Price * Quantity;
    }
}
class ShoppingCart
{
    public List<CartItem> Items = new List<CartItem>();

    public void AddItem(Product product, int quantity)
    {
        Items.Add(new CartItem(product, quantity));
    }

    public void RemoveItem(int productId)
    {
        Items.RemoveAll(item => item.Product.Id == productId);
    }

    public decimal GetCartTotal()
    {
        return Items.Sum(item => item.GetTotalPrice());
    }
}
class Program
{
    static void Main()
    {
        Product p1 = new Product(1, "Laptop", 50000);
        Product p2 = new Product(2, "Mouse", 500);
        Product p3 = new Product(3, "Keyboard", 1000);

        ShoppingCart cart = new ShoppingCart();

        cart.AddItem(p1, 1);
        cart.AddItem(p2, 2);
        cart.AddItem(p3, 1);

        Console.WriteLine("Cart total: ₹" + cart.GetCartTotal());
    }
}
