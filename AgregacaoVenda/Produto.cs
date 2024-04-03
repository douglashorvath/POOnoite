using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        
        private static int codigoGeral;
        public static int CodigoGeral
        {
            get { return codigoGeral; }
            private set { codigoGeral= value; }
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }  

        static Produto()
        {
            CodigoGeral = 500;
        }

        public Produto(string nome, double preco)
        {
            codigoGeral++;
            this.Codigo = codigoGeral;
            this.Nome = nome;
            this.Preco = preco;            
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine($"-> Produto: {Nome}\t Código: {Codigo}\t Preço: {Preco:c}");
        }
        
    }
}