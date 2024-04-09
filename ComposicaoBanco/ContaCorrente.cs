using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Author: Douglas Horvath

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        public double Saldo { get; set; } //Armazena o saldo da conta
        public double ChequeEspecial { get; set; } //Armazena o limite do cheque especial
    

        public ContaCorrente(double sal, double ce)
        {
            Saldo = sal;
            ChequeEspecial = ce;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            //verifica se tem saldo
            if (Saldo >= valor)
            {
                Saldo -= valor;
                return true;
            }
            else
            {
                double resto = Math.Abs(Saldo - valor);
                //verifica se tem limite no cheque especial
                if(ChequeEspecial >= resto)
                {
                    Saldo -= valor;
                    return true;
                }
                else
                    return false;
            }
        }

        public void GerarExtrato()
        {
            Console.WriteLine("Extrato da conta");
            Console.WriteLine("\tSaldo: " + Saldo);
            Console.WriteLine("\tLimite do Cheque Especial: " + ChequeEspecial);
        }
    }
}