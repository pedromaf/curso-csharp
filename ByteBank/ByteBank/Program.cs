using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    class Program
    {
        static void Main(String[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario("Carlos", "546.879.157-20", 2000);

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("Roberta", "454.658.148-3", 5000);

            gerenciador.Registrar(roberta);

            Console.WriteLine(gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}