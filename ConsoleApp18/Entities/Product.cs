using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp18.Entities;

namespace ConsoleApp18.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }
}
