using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("  ");
        Console.WriteLine(" ****************************** ");
        Console.WriteLine("  Product Ordering System 2024 ");
        Console.WriteLine(" ******************************");

        Product product = new Product("Milk", 01, 10, 4);
        Product product2 = new Product("Shawarma", 02, 20, 2);
        Product product3 = new Product("Beans", 03, 10, 5);
        Product product4 = new Product("Rice", 04, 20, 3);
        Product product5 = new Product("Soda", 05, 10, 4);

        List<Product> products = new List<Product>();
        products.Add(product);
        products.Add(product2);
        products.Add(product3);
        products.Add(product4);
        products.Add(product5);

        foreach (Product product1 in products)
        {
            Console.WriteLine(" =============  ");
            Console.WriteLine(product1.DisplayProductInfo());
            var totalAmount = product1.Total();
            Console.WriteLine($" Total Amount of |=={product1.SetName()}==| Ordered: ${totalAmount} ");
        }

        Order order = new Order();
        order.AddProduct(product);
        order.AddProduct(product2);
        order.AddProduct(product3);
        order.AddProduct(product4);
        order.AddProduct(product5);

        Customer customer = new Customer("Moroni Banlard ", new Address("123 Main St", "City", "State", "USA"));
        order.AddCustomer(customer);
        

        Console.WriteLine("============================");
        Console.WriteLine(order.ShippingLabel());
        Console.WriteLine(order.PackingLabel());
        Console.WriteLine("============================");
        Console.WriteLine($"Total Order Amount: ${order.CalculateTotal()}");
        Console.WriteLine("============================");
        Console.WriteLine($" Shipping Label : { order.ShippingLabel()}");
        Console.WriteLine($" Packing Label : {order.PackingLabel()}");
        Console.WriteLine();
    }
}


