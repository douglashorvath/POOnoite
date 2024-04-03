using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {
        public Comprador Comp { get; set; }
        public Vendedor Vend { get; set; }

        private List<Produto> vetProd;
        public List<Produto> VetProd
        {
            get { return vetProd; }
            set { vetProd = value; }
        }
        

        public Venda()
        {
            this.vetProd = new List<Produto>();
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine("----- Venda -----");
            double valorTotal = 0;
            foreach(Produto p in vetProd)
            {
                valorTotal += p.Preco;
            }
            System.Console.WriteLine($"Valor Total: {valorTotal:c}");
            Comp.MostrarAtributos();
            Vend.MostrarAtributos();
            foreach(Produto p in vetProd){
                p.MostrarAtributos();
            }
        }

        public void calcularComissao()
        {
            double comissao = 0;
            foreach(Produto p in vetProd)
            {
                comissao += p.Preco * 0.02;
            }
            Vend.Comissao = comissao;
        }

        public void registraCompra()
        {
            double valorTotal = 0;
            foreach(Produto p in vetProd)
            {
                valorTotal += p.Preco;
            }

            Comp.Verba -= valorTotal;
        }
        
    }
}