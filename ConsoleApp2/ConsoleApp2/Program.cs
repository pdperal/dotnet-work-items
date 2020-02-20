using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program 
    {

        static void Main(string[] args)
        {

            Produto produto = new Produto("TV", 500.00, 10)
            {
                Nome = "T"
            };

            

            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Preco);

        }
     
    }
}
