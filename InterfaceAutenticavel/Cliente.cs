using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Cliente : IAutenticavel //a CLASSE Cliente IMPLEMENTA a INTERFACE IAutenticavel
    {
        public int Senha { get; set; }
        public bool Autenticar(int senha)
        {
            if (Senha == senha)
            {
                System.Console.WriteLine("Cliente Autenticado");
                return true;
            }
            else
            {
                System.Console.WriteLine("Cliente não Autenticado");
                return false;
            }
        }
    }
}