using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorProduto
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public static int Instancias { get; set; }

        public Produto(){
            Instancias++;
        }

        public Produto(int codigo)
        {
            this.Codigo = codigo;
            Instancias++;
        }

        public Produto(int codigo, string nome, double preco)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco = preco;
            Instancias++;
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tPreço: {Preco:c}");
            //System.Console.WriteLine("Código :"+codigo+"\tNome: "+nome+"\t Preço: "+preco);
        }


        
    }
}