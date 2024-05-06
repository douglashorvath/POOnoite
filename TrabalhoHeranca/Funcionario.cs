using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHeranca
{
    public class Funcionario
    {
        protected int codigo;
        public int Codigo
        {
            get { return codigo = 0;; }
            set { codigo = value; }
        }

        protected string nome;
        public string Nome
        {
            get { return nome = "";; }
            set { nome = value; }
        }

        protected double salario;
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public Funcionario(int codigo, string nome, double salario)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.salario = salario;
        }

        public void Mostrar(){
            System.Console.WriteLine($"Código: {codigo} \tNome: {nome} \tSalário: {salario:c}");
        }
        
        
        
    }
}