using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHeranca
{
    public class Mensalista : Funcionario
    {
        private int qtdeHorasTrabalhadas;
        public int QtdeHorasTrabalhadas
        {
            get { return qtdeHorasTrabalhadas;}
            set { qtdeHorasTrabalhadas = value;}
        }

        public Mensalista(int codigo, string nome, double salario, int qtdeHorasTrabalhadas) : base(codigo, nome, salario)
        {
            this.qtdeHorasTrabalhadas = qtdeHorasTrabalhadas;
        }

        public void Mostrar()
        {
            System.Console.WriteLine("------------------- Mensalista --------------------");
            base.Mostrar();
            System.Console.WriteLine("Horas Trabalhadas: "+this.qtdeHorasTrabalhadas);
            System.Console.WriteLine("----------------------------------------------------");
        }
        
    }
}