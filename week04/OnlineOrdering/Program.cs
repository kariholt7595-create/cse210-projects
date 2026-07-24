using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "245 Maple Street",
            "Denver",
            "Colorado",
            "USA"
        );

        Customer customer1 = new Customer("Emily Carter", address1);

        Order order1 = new Order(customer1);

        Product product1 = new Product("Wireless Mouse", "WM101", 24.99, 1);
        Product product2 = new Product("Notebook", "NB205", 4.50, 3);
        Product product3 = new Product("Desk Lamp", "DL310", 32.00, 1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Console.WriteLine("ORDER 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");
        Console.WriteLine();


        Address address2 = new Address(
            "18 King Street",
            "Toronto",
            "Ontario",
            "Canada"
        );

        Customer customer2 = new Customer("Liam Bennett", address2);

        Order order2 = new Order(customer2);

        Product product4 = new Product("Bluetooth Speaker", "BS110", 39.99, 1);
        Product product5 = new Product("Phone Charger", "PC220", 18.50, 2);
        Product product6 = new Product("Travel Mug", "TM330", 14.75, 1);

        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        Console.WriteLine("ORDER 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
        Console.WriteLine();
    }
}