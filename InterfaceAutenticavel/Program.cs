using InterfaceAutenticavel;

Cliente c = new Cliente();
c.Senha = 123;


IAutenticavel itc = c;
System.Console.WriteLine("Autenticou? " + itc.Autenticar(123));

Diretor d = new Diretor();
d.Senha = 200;
IAutenticavel itd = d;
System.Console.WriteLine("Autenticou? " + itd.Autenticar(123));

Gerente g = new Gerente();
g.Senha = 300;
IAutenticavel itg = g;
System.Console.WriteLine("Autenticou? " + itg.Autenticar(300));