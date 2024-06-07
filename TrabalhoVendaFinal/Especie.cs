using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaFinal
{
    public class Especie : Pagamento
    {
        private double quantia;
        public double Quantia
        {
            get { return quantia; ; }
            set
            {
                quantia = value;
                if (base.Vendido != null)
                    Troco = quantia - base.Vendido.Total;
                else
                    Troco = quantia;
            }
        }

        public double Troco { get; private set; }

        public Especie(double quantia, Venda vendido) : base(vendido)
        {
            this.Quantia = quantia;
            if (vendido != null)
                Troco = quantia - vendido.Total;
            else
                Troco = quantia;
        }

        public override void exibirPagamento()
        {
            System.Console.WriteLine("Tipo de Pagamento: Espécie");
            System.Console.WriteLine($"Quantia: {Quantia:c}");
            System.Console.WriteLine($"Troco: {Troco:c}");
            base.exibirPagamento();
        }
    }
}