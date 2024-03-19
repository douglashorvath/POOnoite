using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayProduto
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public double preco;
        public int quantidade;

        //metodos
        //crie um método para apresentar os atributos da classe
        //crie um metodo para calcular o aumento do preço, por meio de uma porcentagem via parâmetro

        //mostrar os atributos da classe
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {codigo}\tNome: {nome}\tQuantidade: {quantidade}\tPreço: {preco:c}\tValor em Estoque:{ValorTotalEmEstoque():c}");
            //System.Console.WriteLine("Código :"+codigo+"\tNome: "+nome+"\t Preço: "+preco);
        }

        //calcular o aumento;
        public void AumentarValor(double porcentagem)
        {
            preco = preco + (preco/100*porcentagem);
        }

        public double ValorTotalEmEstoque()
        {
            return quantidade*preco;
        }

        public void RemoverEstoque(int quantidade)
        {
            this.quantidade -= quantidade;
        }
    }
}