using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAbstract
{
    public abstract class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        private List<Dependente> dependentes;

        public Funcionario(int codigo, string nome, double salario)
        {
               Codigo = codigo;
               Nome = nome;
               Salario = salario;
               dependentes = new List<Dependente>();
        }

        public virtual void Mostrar()
        {
            System.Console.WriteLine($"Código: {Codigo}\tNome: {Nome}\tSalario: {Salario:c}");
        }

        public void AdicionarDependente(Dependente dependente)
        {
            dependentes.Add(dependente);
        }

        public void removerDependente(int codigo)
        {
            dependentes.Remove(dependentes.Find(x => x.Codigo == codigo));
        }

        public int totalDependentes()
        {
            return dependentes.Count;
        }

        public void MostrarDependentes()
        {
            System.Console.WriteLine($"Dependentes de {Nome}:");
            foreach (Dependente d in dependentes)
            {
                d.Mostrar();
            }
        }

        public abstract double CalcularSalario(int diasUteis);
        /* assinatura de método - sabemos o que o método faz pelo seu nome,
        sabemos se precisa de valor externo para atender o desenvolvimento da lógica (parametros) 
        e sabemos se ocorrerá saída de valor;*/
    }
}