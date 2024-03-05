using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        public int codigo;
        public string nome;
        public double preco;

        //metodos
        //crie um método para apresentar os atributos da classe
        //crie um metodo para calcular o aumento do preço, por meio de uma porcentagem via parâmetro

        //mostrar os atributos da classe
        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {codigo}\tNome: {nome}\tPreço: {preco}");
            //System.Console.WriteLine("Código :"+codigo+"\tNome: "+nome+"\t Preço: "+preco);
        }

        //calcular o aumento;
        public void AumentarValor(double porcentagem)
        {
            preco = preco + (preco/100*porcentagem);
        }
    }
}