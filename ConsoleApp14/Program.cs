using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp14.Entities;
using ConsoleApp14.Entities.Enums;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order { 
                Id = 1, 
                Moment = DateTime.Now, 
                Status = OrderStatus.Delivered 
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            Console.ReadLine();
        }


    }
}
