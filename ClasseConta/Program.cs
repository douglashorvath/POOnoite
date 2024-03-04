//função main

using ClasseConta;

Conta objetoConta = new Conta();

objetoConta.setNumero(1);
objetoConta.setSaldo(100.57);
objetoConta.setTitular("Paul");

System.Console.WriteLine("Titular: "+objetoConta.getTitular());
System.Console.WriteLine("Número: "+objetoConta.getNumero());
System.Console.WriteLine("Saldo: "+objetoConta.getSaldo());

Conta objetoConta2 = new Conta();
System.Console.WriteLine("Digite o número: ");
objetoConta2.setNumero(Convert.ToInt32(Console.ReadLine()));
System.Console.WriteLine("Digite o titular: ");
objetoConta2.setTitular(Console.ReadLine());
System.Console.WriteLine("Digite o Saldo: ");
objetoConta2.setSaldo(Convert.ToDouble(Console.ReadLine()));

objetoConta2.MostrarAtributos();
