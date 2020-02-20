using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Funcionario
    {
        public string Nome { get; set; }
        public int ID { get; set; }
        public double Salario { get; private set; }

        public Funcionario(string nome, int id, double salario)
        {
            Nome = nome;
            ID = id;
            Salario = salario;
        }
        public void AumentoSalario(double percentual)
        {
            var porcentagem = (percentual / 100) * Salario;
            Salario += porcentagem;
        }

        public override string ToString()
        {
            return ID
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2");
        }
    }
}
