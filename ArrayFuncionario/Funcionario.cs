using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArrayFuncionario
{
    public class Funcionario
    {
        public int codigo;
        public string nome;
        public double salario;

        // public Funcionario(int codigo, string nome, double salario)
        // {
        //     this.codigo = codigo;
        //     this.nome = nome;
        //     this.salario = salario;
        // }

        public void MostrarAtributos()
        {
            System.Console.WriteLine($"Código: {codigo}\tNome: {nome}\tSalario: {salario:c}");
            //System.Console.WriteLine("Código :"+codigo+"\tNome: "+nome+"\t Preço: "+preco);
        }
    }
}