using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaFinal
{
    public class Cheque : Pagamento
    {
        public long Numero { get; set; }
        public DateTime DataDeposito { get; set; }
        public int Situacao { get; set; }

        public Cheque(long numero, DateTime dataDeposito, int situacao, Venda vendido) : base(vendido)
        {
            this.Numero = numero;
            this.DataDeposito = dataDeposito;
            this.Situacao = situacao;
        }

        public override void exibirPagamento()
        {
            System.Console.WriteLine("Tipo de Pagamento: Cheque");
            System.Console.WriteLine("Número do Cheque: " + Numero);
            System.Console.WriteLine("Data do Depósito: " +DataDeposito.ToString("dd/MM/yyyy"));
            System.Console.WriteLine("Situação: " + Situacao);
            base.exibirPagamento();
        }
    }
}