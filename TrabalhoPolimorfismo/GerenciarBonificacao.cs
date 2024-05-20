using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPolimorfismo
{
    public class GerenciarBonificacao
    {
        private double totalBonificacao;
        public double TotalBonificacao
        {
            get { return totalBonificacao; }
            set { totalBonificacao = value; }
        }

        public GerenciarBonificacao()
        {
            totalBonificacao = 0;
        }

        public void TotalizadorBonificacao(Funcionario funcionario)
        {
            totalBonificacao += funcionario.calculaBonificacao();
        }

        public void TotalizadorBonificacao(Gerente gerente)
        {
            totalBonificacao += gerente.calculaBonificacao();
        }

        public void TotalizadorBonificacao(Diretor diretor)
        {
            totalBonificacao += diretor.calculaBonificacao();
        }

        public void TotalizadorBonificacao(Secretario secretario)
        {
            totalBonificacao += secretario.calculaBonificacao();
        }


    }
}