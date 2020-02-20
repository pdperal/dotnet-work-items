using System;
using System.Linq;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel[] vetorHotel = new Hotel[10];
            double aluguel = 0;
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                aluguel += 100;
                Console.WriteLine($"Aluguel {i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vetorHotel[i] = new Hotel (nome, email);
                Console.WriteLine();
            
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < vetorHotel.Length; i ++)
            {
                if (vetorHotel[i] != null)
                {
                    Console.WriteLine($"{i}: {vetorHotel[i].ToString()}");
                }

            }   

            Console.WriteLine($"Receita total de aluguel: {aluguel}");
        }
    }
}
