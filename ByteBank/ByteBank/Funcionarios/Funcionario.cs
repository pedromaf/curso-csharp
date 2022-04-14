using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public double Salario { get; private set; }


        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            CPF = cpf;
            Salario = salario;
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
