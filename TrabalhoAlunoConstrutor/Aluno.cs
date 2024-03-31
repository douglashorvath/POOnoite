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
        
        public string Nome { get; set; }
        public double P1 { get; set; }
        public double P2 { get; set; }
        public double Media;

        static Aluno()
        {
            matricula = 1570482410000;
        }

        public Aluno()
        {
            Matricula++;
        }

        public double CalcularMedia()
        {
            Media = (P1+P2)/2;
            return Media;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"P1: {P1}");
            Console.WriteLine($"P2: {P2}");
            Console.WriteLine($"Média: {CalcularMedia()}");
        }
    }
}