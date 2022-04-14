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
            CalcularBonificacao();
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Funcionario funcionarioDiretor = new Diretor("Lucas", "109.902.624-56", 5000);
            Funcionario funcionarioGerente = new Gerente("Jorge", "109.902.624-55", 4000);
            Funcionario funcionarioAuxiliar = new Auxiliar("Jessica", "109.902.624-54", 3000);
            Funcionario funcionarioDesigner = new Designer("Leprechaum", "109.902.624-57", 2000);
            Funcionario funcionarioDesenvolvedor = new Desenvolvedor("Pedro", "109.902.624-50", 3500);

            gerenciadorBonificacao.Registrar(funcionarioDiretor);
            gerenciadorBonificacao.Registrar(funcionarioGerente);
            gerenciadorBonificacao.Registrar(funcionarioAuxiliar);
            gerenciadorBonificacao.Registrar(funcionarioDesigner);
            gerenciadorBonificacao.Registrar(funcionarioDesenvolvedor);

            Console.WriteLine(gerenciadorBonificacao.GetTotalBonificacao());
            Console.WriteLine(Funcionario.TotalDeFuncionarios);
        }
    }
}