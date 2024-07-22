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

        Console.WriteLine();
        Console.WriteLine("======================  ");
        Console.WriteLine("    FIRST ORDER | ");
        Console.WriteLine("======================  ");

        Product product = new Product("Milk", 01, 10, 4);
        Product product2 = new Product("Shawarma", 02, 20, 2);
        Product product3 = new Product("Beans", 03, 10, 5);
        Product product4 = new Product("Rice", 04, 20, 3);

        List<Product> products = new List<Product>();
        products.Add(product);
        products.Add(product2);
        products.Add(product3);
        products.Add(product4);
      

        foreach (Product product1 in products)
        {
            
            
            Console.WriteLine(product1.DisplayProductInfo());
            var totalAmount = product1.Total();
            Console.WriteLine($" Total Amount of | {product1.SetName()} | Ordered: ${totalAmount} ");
        }


        // First order 
        Order order = new Order();
        order.AddProduct(product);
        order.AddProduct(product2);
        order.AddProduct(product3);
        order.AddProduct(product4);
      

        Customer customer = new Customer("Moroni Banlard ", new Address("123 Main St", "City", "State", "USA"));
        order.AddCustomer(customer);


        
        Console.WriteLine();
        Console.WriteLine("============================");
        Console.WriteLine($"Total Order Amount: ${order.CalculateTotal()}");
        Console.WriteLine("============================");
        Console.WriteLine($" Shipping Label : { order.ShippingLabel()}");
        Console.WriteLine($" Packing Label : {order.PackingLabel()}");
        Console.WriteLine();

        // Second order 
        Console.WriteLine();
        Console.WriteLine("======================  ");
        Console.WriteLine("    SECOND ORDER | ");
        Console.WriteLine("======================  ");

        Product productList1 = new Product("Milk", 01, 10, 8);
        Product productList2 = new Product("Shawarma", 02, 20, 9);
        Product productList3 = new Product("Beans", 03, 10, 12);
        Product productList4 = new Product("Soda", 05, 10, 43);

        List<Product> products1 = new List<Product>();
        products1.Add(productList1);
        products1.Add(productList2);
        products1.Add(productList3);
        products1.Add(productList4);

        foreach (Product product6 in products1)
        {

            Console.WriteLine(product6.DisplayProductInfo());
            var totalAmount = product6.Total();
            Console.WriteLine($" Total Amount of | {product6.SetName()} | Ordered: ${totalAmount} ");
        }

        Order order2 = new Order();
        order2.AddProduct(productList1 );
        order2.AddProduct(productList2);
        order2.AddProduct(productList3);
        order2.AddProduct(productList4);

        Customer customer2 = new Customer(" Monday Eseinone ", new Address("893 Ayobo St", "Lagos ", "State", "Ikeja"));
        order2.AddCustomer(customer2);

        Console.WriteLine();
        Console.WriteLine("============================");
        Console.WriteLine($"Total Order Amount: ${order2.CalculateTotal()}");
        Console.WriteLine("============================");
        Console.WriteLine($" Shipping Label : { order2.ShippingLabel()}");
        Console.WriteLine($" Packing Label : {order2.PackingLabel()}");
        Console.WriteLine();
    
        
    }
}


