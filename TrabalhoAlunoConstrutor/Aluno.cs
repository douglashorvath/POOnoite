using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoAlunoConstrutor
{
    public class Aluno
    {
        private static long matricula;
        public long Matricula
        {
            get { return matricula; }
            private set { matricula = value; }
        }
        
        
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { 
                if(value.Trim() != "")
                {
                    nome = value;
                }
                else{
                    System.Console.WriteLine("Nome inválido!");
                }
             }
        }
        
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double Media { get; private set; }

        static Aluno()
        {
            matricula = 1570482410000;
        }

        public Aluno()
        {
            Matricula++;
        }

        public void CalcularMedia()
        {
            Media = (P1+P2)/2;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"P1: {P1}");
            Console.WriteLine($"P2: {P2}");
            Console.WriteLine($"Média: {Media}");
        }
    }
}