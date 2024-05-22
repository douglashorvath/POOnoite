using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAbstract
{
    public class Departamento
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Funcionario> VetF { get; set; }

        public Departamento(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public void AdmitirFuncionario(Funcionario f)
        {
            VetF.Add(f);
        }

        public void ListarFuncionarios()
        {
            System.Console.WriteLine($"--------------- Departamento {Nome} ({Codigo}) ------------");
            foreach (Funcionario f in VetF)
            {
                f.Mostrar();
            }
        }

        public void DemitirFuncionario(int codigo)
        {
            foreach (Funcionario f in VetF)
            {
                if (f.Codigo == codigo)
                {
                    VetF.Remove(f);
                    break;
                }
            }
        }

        public double CalcularFolha(int diasUteis)
        {
            double total = 0;
            foreach (Funcionario f in VetF)
            {
                total += f.CalcularSalario(diasUteis);
            }
            return total;
        }

        public void MostrarQtdeDependentesFuncionarios()
        {
            int qtde = 0;
            foreach (Funcionario f in VetF)
            {
                qtde += f.totalDependentes();
            }
            System.Console.WriteLine($"--------------- Departamento {Nome} ({Codigo}) ------------");
            System.Console.WriteLine($"Quantidade Total de Dependentes: {qtde}");
        }
    }
}