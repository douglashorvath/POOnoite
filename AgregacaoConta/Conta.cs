using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Conta
    {
        //Agregação acontece aqui (associação entre classes)
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public int Saldo { get; set; }

        public Conta(Cliente titular, int numero, int saldo)
        {
            this.Titular = titular;
            this.Numero = numero;
            this.Saldo = saldo;
        }

        public void MostrarAtributos(){
            System.Console.WriteLine("Número: "+this.Numero);
            System.Console.WriteLine("Nome do Titular: "+this.Titular.Nome);
            Titular.EnderecoCliente.MostrarEndereco();
            System.Console.WriteLine("RG do Titular: "+this.Titular.Rg);
            System.Console.WriteLine("CPF do Titular: "+this.Titular.Cpf);
            System.Console.WriteLine("Saldo: "+this.Saldo);
        }

    }
}