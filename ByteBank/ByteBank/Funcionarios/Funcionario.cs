﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }


        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }

        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}
