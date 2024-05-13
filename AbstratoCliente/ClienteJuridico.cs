using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteJuridico: Cliente
    {
        private string cnpj;
        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public ClienteJuridico() : base()
        {
            
        }

        public ClienteJuridico(int codigo, string nome, string endereco, string cnpj) : base(codigo, nome, endereco)
        {
            this.cnpj = cnpj;
        }

        public void Mostrar(){
            base.Mostrar();
            System.Console.WriteLine("CNPJ: "+this.cnpj);
        }
        
    }
}