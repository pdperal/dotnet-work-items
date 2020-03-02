using System;
using ConsoleApp16.Entities;
using ConsoleApp16.Entities.Enums;


namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o nome do departamento");
            string departmentName = Console.ReadLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Dados do trabalhador");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/Pleno/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine().ToUpper());
            Console.Write("Salario: ");
            double salary = double.Parse(Console.ReadLine());

            Departmenrt departmenrt = new Departmenrt(departmentName);
            Worker worker = new Worker(name, level, salary, departmenrt);

            Console.Write("Quantos contratos o trabalhador tem? ");
            int contratos = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            for (int i = 1; i <= contratos; i++)
            {
                Console.WriteLine($"Informe os dados do #{i} contrato:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine());
                Console.Write("Duração: ");
                int duracao = int.Parse(Console.ReadLine());

                HourContract contrato = new HourContract(date, valorHora, duracao);

                worker.AddContract(contrato);
            }
            Console.WriteLine();

            Console.Write("Informe o mês e ando para calcular o income (MM/YYYY): ");
            string mesAno = Console.ReadLine();
            int mes = int.Parse(mesAno.Substring(0,2));
            int ano = int.Parse(mesAno.Substring(3));

            Console.WriteLine($"Nome: {worker.Name}");
            Console.WriteLine($"Departamento: {worker.Department.Name}");
            var totalIncome = worker.Income(ano, mes);
            Console.WriteLine($"Income for {mes}/{ano}: {totalIncome}");
            

        }
    }
}
