
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {

        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
           
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario + (base.GetBonificacao());
        }
    }
}
