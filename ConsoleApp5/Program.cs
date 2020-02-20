using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            Console.Write("Informe quantos funcionários serão criados: ");
            int qtdFunc = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdFunc; i++)
            {
                Console.Write("Informe o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Informe o ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Informe o salario: ");
                double salario = double.Parse(Console.ReadLine());
                list.Add(new Funcionario(nome, id, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Informe o id do funcionario que terá o salario aumentado: ");
            int procurarId = int.Parse(Console.ReadLine());

            Funcionario func = list.Find(x => x.ID == procurarId);
            if(func != null)
            {
                Console.Write("informe o percentual: ");
                double percentual = double.Parse(Console.ReadLine());
                func.AumentoSalario(percentual);
            }
            else
            {
                Console.WriteLine("Id não existe");
            }

            Console.WriteLine();
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
 