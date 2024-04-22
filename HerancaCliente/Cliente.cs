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
        public string nome
        {
            get { return nome; }
            set { nome = value; }
        }

        protected string endereco;
        public string Enderebo
        {
            get { return endereco; }
            set { endereco = value; }
        }
        
        
        
    }
}