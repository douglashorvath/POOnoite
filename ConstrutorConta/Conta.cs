using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public static int Contador { get; set; }

        public Conta()
        {
            Contador++;
        }

        public Conta(int numero)
        {
            Numero = numero;
            Contador++;
        }

        public Conta(int numero, double saldo)
        {
            this.Numero = numero;
            this.Saldo = saldo;
            Contador++;
        }

        public void MostrarAtributos(){
            System.Console.WriteLine("Número: "+Numero);
            System.Console.WriteLine("Titular: "+Titular);
            System.Console.WriteLine("Saldo: "+Saldo);
        }
    }
}