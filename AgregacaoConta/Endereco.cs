using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoConta
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }

        public Endereco(string logradouro, int numero, string cidade)
        {
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Cidade = cidade;
        }

        public void MostrarEndereco()
        {
            System.Console.WriteLine("Endereço: "+Logradouro+"\t Número: "+Numero+"\t Cidade:"+Cidade);
        }
    }
}