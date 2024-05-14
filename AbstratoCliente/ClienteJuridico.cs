using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
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

        public ClienteJuridico(int codigo, string nome, string endereco, int idade, string cnpj) : base(codigo, nome, endereco, idade)
        {
            this.cnpj = cnpj;
        }

        public override void Mostrar(){
            System.Console.WriteLine("Codigo: "+Codigo+"\tNome: "+this.Nome+"\tEndereço: "+this.Endereco+"\tCNPJ: "+this.Cnpj);
        }

        public override void AValiarIdade(){
            if(this.idade >= 40){
                System.Console.WriteLine("Cliente Jurídico");
            }
        }
        
    }
}