using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Diretor : Funcionario, IAutenticavel
    {
        public bool Autenticar(int senha)
        {
            if (Senha == senha)
            {
                System.Console.WriteLine("Diretor Autenticado");
                return true;
            }
            else
            {
                System.Console.WriteLine("Diretor não Autenticado");
                return false;
            }
        }
    }
}