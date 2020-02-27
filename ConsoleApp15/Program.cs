using System;
using ConsoleApp15.Entities;
using ConsoleApp15.Entities.Enums;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1,
                Moment = DateTime.Now,
                Status = OrderStatus.Delivered
            };

            Console.WriteLine(order);
            Console.WriteLine("------------------------");
            var txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(txt);

            Console.WriteLine("------------------------");
            Console.WriteLine(os);

        }
    }
}
