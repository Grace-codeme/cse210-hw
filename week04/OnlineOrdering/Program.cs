using System;

class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address("123 Main St", "Ibadan", "Oyo", "Nigeria");
        var customer1 = new Customer("Abdullahi Grace", address1);
        var order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "L123", 1000, 1));
        order1.AddProduct(new Product("Mouse", "M123", 20, 2));

        var address2 = new Address("456 Elm St", "Lagos", "Lagos", "Nigeria");
        var customer2 = new Customer("Abdullahi Mercy", address2);
        var order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P123", 500, 1));
        order2.AddProduct(new Product("Headphones", "H123", 50, 2));

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}
