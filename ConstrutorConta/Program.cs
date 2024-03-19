//main
using ConstrutorConta;


Conta c1 = new Conta();
c1.MostrarAtributos();

Conta c2 = new Conta(235);
c2.MostrarAtributos();

Conta c3 = new Conta(1,50);
c3.MostrarAtributos();

Conta c4 = new Conta(50,1);
c4.MostrarAtributos();

System.Console.WriteLine("Número de instâncias: "+Conta.Contador);
