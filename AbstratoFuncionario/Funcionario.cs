using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoFuncionario
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario(int codigo, string nome, double salario)
        {
               Codigo = codigo;
               Nome = nome;
               Salario = salario;
        }

        public virtual void Mostrar()
        {
            System.Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tSalario: {Salario:c}");
        }

        public abstract double CalcularSalario(int diasUteis);
        /* assinatura de método - sabemos o que o método faz pelo seu nome,
        sabemos se precisa de valor externo para atender o desenvolvimento da lógica (parametros) 
        e sabemos se ocorrerá saída de valor;*/
    }
}