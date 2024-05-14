using AbstratoFuncionario;

Assalariado a1 = new Assalariado(10, "John", 1000);
Assalariado a2 = new Assalariado(20, "Fred", 1000);

Comissionado c1 = new Comissionado(30, "Will", 1000, 20);
Comissionado c2 = new Comissionado(40, "July", 1000, 30);

Departamento d1 = new Departamento(120, "TI");
d1.VetF = new List<Funcionario>();
Departamento d2 = new Departamento(220, "RH");
d2.VetF = new List<Funcionario>();

d1.AdmitirFuncionario(a1);
d1.AdmitirFuncionario(c1);

d2.AdmitirFuncionario(a2);
d2.AdmitirFuncionario(c2);

d1.ListarFuncionarios();
d2.ListarFuncionarios();

System.Console.WriteLine("Folha de pagamento:");
System.Console.WriteLine($"Departamento {d1.Nome} ({d1.Codigo}): {d1.CalcularFolha(30):c}");
System.Console.WriteLine($"Departamento {d2.Nome} ({d2.Codigo}): {d2.CalcularFolha(30):c}");

d1.DemitirFuncionario(10);
d2.DemitirFuncionario(40);

d1.ListarFuncionarios();
d2.ListarFuncionarios();

System.Console.WriteLine("Folha de pagamento:");
System.Console.WriteLine($"Departamento {d1.Nome} ({d1.Codigo}): {d1.CalcularFolha(30):c}");
System.Console.WriteLine($"Departamento {d2.Nome} ({d2.Codigo}): {d2.CalcularFolha(30):c}");
