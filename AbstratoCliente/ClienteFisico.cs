using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class ClienteFisico : Cliente
    {
        private string rg;
        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public ClienteFisico() : base()
        {
            
        }

        public ClienteFisico(int codigo, string nome, string endereco, string rg) : base(codigo, nome, endereco)
        {
            this.rg = rg; 
        }

        public void Mostrar(){
            base.Mostrar();
            System.Console.WriteLine("RG: "+this.Rg);
        }
        
    }
}