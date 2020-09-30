using Exercicio121.Entities;
using System;
using System.Collections.Generic;

namespace Exercicio121
{
    class Program
    {
        static void Main(string[] args)
        {
            Client cliente = new Client();
            Order order = new Order();
            OrderItem orderItem = new OrderItem();
            Product product = new Product();

            Console.WriteLine("Enter cliente data:");
            Console.WriteLine("Name: ");
            cliente.Name = Console.ReadLine();
            Console.WriteLine("Email: ");
            cliente.Email = Console.ReadLine();
            Console.WriteLine("Birth date (dd/mm/yyyy): ");
            cliente.BirthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data: ");
            Console.WriteLine("Status: ");
            order.Status = Enum.Parse<OrderStatus>(Console.ReadLine().ToString());
            Console.WriteLine("How many items to this order? ");
            orderItem.Quantity = int.Parse(Console.ReadLine().ToString());

            for (int i = 1; i <= orderItem.Quantity; i++)
            {
                var listaProduto = new List<Product>();
                Console.WriteLine($"Enter #{i} item data: ");
                Console.WriteLine("Product name: ");
                product.Name = Console.ReadLine();
                Console.WriteLine("Product price: ");
                product.Price = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantity: ");
                product.
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                product
                listaProduto.Add(new Product()
                {
                    Name
                    Hours = hourContract.Hours
                });

            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
