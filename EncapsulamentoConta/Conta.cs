using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        private int numero;
        private string? titular;
        private double saldo;

        public int Numero{ //propriedade
            set{
                this.numero = value;
            }
            get{
                return this.numero;
            }
        }

        
        
    }
}