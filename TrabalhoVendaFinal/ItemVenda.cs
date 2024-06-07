using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaFinal
{
    public class ItemVenda
    {
        private Produto prod;
        public Produto Prod
        {
            get { return prod; }
            set
            {
                prod = value;
                Subtotal = prod.Preco * Quantidade;
            }
        }

        private int quantidade = 0;
        public int Quantidade
        {
            get { return quantidade; }
            set
            {
                quantidade = value;
                Subtotal = prod.Preco * Quantidade;
            }
        }

        public double Subtotal { get; private set; }

        public ItemVenda(Produto prod, int quantidade)
        {
            this.Prod = prod;
            this.Quantidade = quantidade;
            this.Subtotal = prod.Preco * Quantidade;
        }

        public void exibirItem()
        {
            System.Console.WriteLine($"Produto: {prod.Nome}\tQuantidade: {quantidade}\tSubtotal: {Subtotal:c}");
        }


    }
}