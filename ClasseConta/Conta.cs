using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta //toda classe é um tipo de dado
    {
        //declaração dos atributos
        private int numero;
        private string titular;
        private double saldo;

        //declaracao de metodos

        public void MostrarAtributos(){
            System.Console.WriteLine("Número: "+numero);
            System.Console.WriteLine("Titular: "+titular);
            System.Console.WriteLine("Saldo: "+saldo);
        }


        public void Sacar(double valor)
        {
            saldo = saldo - valor;
        }

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public int getNumero()
        { 
            return numero;
        }
        public void setNumero(int numero){
            this.numero = numero;
        }

        public string getTitular()
        {
            return titular;
        }
        public void setTitular(string titular)
        {
            this.titular = titular;
        }

        public double getSaldo()
        {
            return saldo;
        }
        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

    }
}