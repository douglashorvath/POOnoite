using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoPolimorfismo
{
    public class Funcionario
    {
        protected int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        protected string nome;
        public string Nome
        {
            get { return Nome; }
            set { Nome = value; }
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

        public virtual double calculaBonificacao()
        {
            return salario + (salario / 100 * 10);
        }



    }
}