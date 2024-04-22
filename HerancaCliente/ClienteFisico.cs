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

        public void Mostrar(){
            System.Console.WriteLine("Nome: "+this.Nome+"\tEndereço: "+this.Endereco+"\tRG: "+this.Rg);
        }
        
    }
}