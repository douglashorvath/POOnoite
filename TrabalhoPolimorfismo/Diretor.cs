using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPolimorfismo
{
    public class Diretor : Funcionario
    {
        public Diretor(int codigo, string nome, double salario) : base(codigo, nome, salario)
        {

        }

        public override double calculaBonificacao()
        {
            return salario + (salario / 100 * 10) + 1000;
        }
    }
}