using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public class Gerente : Funcionario, IAutenticavel
    {
        public bool Autenticar(int senha)
        {
            if (Senha == senha)
            {
                System.Console.WriteLine("Funcionario Autenticado");
                return true;
            }
            else
            {
                System.Console.WriteLine("Funcionario não Autenticado");
                return false;
            }
        }
    }
}