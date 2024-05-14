using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
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

        public ClienteFisico(int codigo, string nome, string endereco, int idade, string rg) : base(codigo, nome, endereco, idade)
        {
            this.rg = rg; 
        }

        public override void Mostrar(){
            System.Console.WriteLine("Codigo: "+Codigo+"\tNome: "+this.Nome+"\tEndereço: "+this.Endereco+"\tRG: "+this.Rg);
        }

        public override void AValiarIdade(){
            if(this.idade >= 18 && this.idade < 40){
                System.Console.WriteLine("Cliente Fisico");
            }
        }
        
    }
}