using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabalhoHeranca
{
    public class Horista : Funcionario
    {
        private int qtdeHorasSemana;
        public int QtdeHorasSemana
        {
            get { return qtdeHorasSemana; }
            set { qtdeHorasSemana = value; }
        }

        public Horista(int codigo, string nome, double salario, int qtdeHorasSemana) : base(codigo, nome, salario)
        {
            this.qtdeHorasSemana = qtdeHorasSemana;
        }

        public void Mostrar()
        {
            System.Console.WriteLine("------------------- Horista --------------------");
            base.Mostrar();
            System.Console.WriteLine("Quantidade de horas semanais: " + this.qtdeHorasSemana);
            System.Console.WriteLine("----------------------------------------------------");
        }
        
    }
}