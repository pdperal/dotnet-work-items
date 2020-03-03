using System;
using ConsoleApp18.Entities;
using ConsoleApp18.Entities.Enums;
namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birthdate: ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthdate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine().ToUpper());
            Order order = new Order(DateTime.Now, status);

            Console.WriteLine("How many items to this order: ");
            int qtd = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Enter the {i} item data:");
                Console.Write("Product name:");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine());
                Product product = new Product(nameProduct, priceProduct);

                Console.WriteLine("Quantity:");
                int qtdProduct = int.Parse(Console.ReadLine());                
                OrderItem orderItem = new OrderItem(qtdProduct, priceProduct, product);                
                order.AddItem(orderItem);
            }

            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order.ToString());
            

        }
    }
}
