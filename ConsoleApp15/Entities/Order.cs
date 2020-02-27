using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp15.Entities.Enums;

namespace ConsoleApp15.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"{Id} \n{Moment} \n{Status}";
        }
    }
}
