using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HerancaCliente
{
    public class Cliente
    {
        protected int codigo;
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        protected string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        protected string endereco;
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public Cliente()
        {
            
        }

        public Cliente(int codigo, string nome, string endereco)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.endereco = endereco;            
        }
        
        public void Mostrar(){
            System.Console.WriteLine("Codigo: "+Codigo+"\tNome: "+this.Nome+"\tEndereço: "+this.Endereco);
        }
        
    }
}