using AgregacaoArrayConta;

Conta c1 = new Conta();
c1.Numero = 1;
c1.Saldo = 100;
c1.Titulares = new List<Cliente>();
//inserir 3 titulares
for(int i=0; i<3; i++)
{
    Cliente cli = new Cliente();
    System.Console.WriteLine("Informe o nome:");
    cli.Nome = Console.ReadLine();
    System.Console.WriteLine("Informe o RG:");
    cli.Rg = Console.ReadLine();
    c1.Titulares.Add(cli);
}

c1.MostrarAtributos();
foreach(Cliente c in c1.Titulares){
    c.Mostrar();
}
