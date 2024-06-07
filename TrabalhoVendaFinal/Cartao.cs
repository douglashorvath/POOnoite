using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaFinal
{
    public class Cartao : Pagamento
    {
        public string DadosTransacao { get; set; }
        public int resultadoTransacao { get; set; }

        public Cartao(string dadosTransacao, int resultadoTransacao, Venda vendido) : base(vendido)
        {
            this.DadosTransacao = dadosTransacao;
            this.resultadoTransacao = resultadoTransacao;
        }

        public override void exibirPagamento()
        {
            System.Console.WriteLine("Tipo de Pagamento: Cartão");
            System.Console.WriteLine("Dados da Transação: " + DadosTransacao);
            System.Console.WriteLine("Resultado da Transação: " + resultadoTransacao);
            base.exibirPagamento();
        }

    }
}