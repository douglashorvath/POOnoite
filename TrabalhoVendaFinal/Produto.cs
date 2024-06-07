using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoVendaFinal
{
    public class Produto
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public Produto(long codigo, string nome, double preco, int estoque)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
            this.Estoque = estoque;
        }

        public void removeEstoque(int remove)
        {
            this.Estoque = Estoque - remove;
        }

        public void exibirProduto(){
            Console.WriteLine($"Código: {Codigo}, Nome: {Nome}, Preço: {Preco}, Estoque: {Estoque}");
        }
    }
}