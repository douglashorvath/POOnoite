using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoFuncionario
{
    public class Funcionario
    {
        private int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private double salario;
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

         public void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {codigo}\tNome: {nome}\tSalario: {salario:c}");
            //System.Console.WriteLine("Código :"+codigo+"\tNome: "+nome+"\t Preço: "+preco);
        }
        
        
        
    }
}