using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAutenticavel
{
    public interface IAutenticavel
    {
        bool Autenticar(int senha); // Assinatura de método, é apenas o que tem dentro da interface
    }
}