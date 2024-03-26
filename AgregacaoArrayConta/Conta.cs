using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoArrayConta
{
    public class Conta
    {
        public List<Cliente> Titulares { get; set; }
        public int Numero { get; set; }
        public int Saldo { get; set; }

        

        public void MostrarAtributos(){
            System.Console.WriteLine("Número: "+this.Numero);
            System.Console.WriteLine("Saldo: "+this.Saldo);
        }
    }
}