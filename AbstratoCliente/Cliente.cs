using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstratoCliente
{
    public abstract class Cliente //classes abstratas não podem ser instanciadas
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

        protected int idade;
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
        

        public Cliente()
        {
            
        }

        public Cliente(int codigo, string nome, string endereco, int idade)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.endereco = endereco;            
            this.idade = idade;
        }

        //a utilização de um método abstrato cria a obrigação da implementação do método nas classes filhas ou em tempo de instanciamento;
        public abstract void Mostrar(); //métodos abstratos não podem ser instanciados, apenas sobrescritos;

        public abstract void AValiarIdade(); //métodos abstratos não podem ser instanciado, esse foi implementado na classe Teste

        
        
    }
}