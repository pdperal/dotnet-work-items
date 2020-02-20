using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Conta
    {
        public string TitularConta { get; set; }
        public int NumeroConta { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string titular, int numeroconta)
        {
            TitularConta = titular;
            NumeroConta = numeroconta;
        }

        public Conta(string titular, int numeroconta, double saldo) : this(titular, numeroconta)
        {
            Deposito(saldo);
        }
        public void Deposito(double valor)
        {
            Saldo += valor;
        }
            
        public void Saque(double valor)
        {
            Saldo -= valor + 5.00;
        }


        public override string ToString()
        {
            return $"Conta: {NumeroConta}, Titular: {TitularConta}, Saldo: {Saldo}";
        }
    }
}

