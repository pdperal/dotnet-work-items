using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroConta;
            string titular;
            double deposito = 0;
            Conta conta;

            Console.Write("Entre com o número da conta: ");
            numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? ");
            var tmp = Console.ReadLine();
            
            if (tmp.ToLower() == "s")
            {
                Console.Write("Informe o valor para depósito: ");
                deposito = double.Parse(Console.ReadLine());
                Console.WriteLine();
                conta = new Conta(titular, numeroConta, deposito);
            }
            else
            {
                conta = new Conta(titular, numeroConta);
            }

            Console.WriteLine("Dados da conta: \n" + conta.ToString());
            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            var valor = double.Parse(Console.ReadLine());
            conta.Deposito(valor);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados: \n" + conta.ToString());

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            conta.Saque(valor);
            Console.WriteLine("Dados da conta atualizados: \n" + conta.ToString());
        }
    }
}
