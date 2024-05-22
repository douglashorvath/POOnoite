using TrabalhoAbstract;

Assalariado a1 = new Assalariado(10, "John", 1000);
Assalariado a2 = new Assalariado(20, "Fred", 1000);

Comissionado c1 = new Comissionado(30, "Will", 1000, 20);
Comissionado c2 = new Comissionado(40, "July", 1000, 30);

Dependente dep1 = new Dependente(1, "João", 23);
Dependente dep2 = new Dependente(2, "Maria", 22);
Dependente dep3 = new Dependente(3, "Pedro", 25);
Dependente dep4 = new Dependente(4, "Ana", 24);
Dependente dep5 = new Dependente(5, "Lucas", 26);
Dependente dep6 = new Dependente(6, "Carla", 27);
Dependente dep7 = new Dependente(7, "Rafael", 28);
Dependente dep8 = new Dependente(8, "Beatriz", 21);
Dependente dep9 = new Dependente(9, "Fernando", 30);
Dependente dep10 = new Dependente(10, "Gabriela", 29);
Dependente dep11 = new Dependente(11, "Marcelo", 31);
Dependente dep12 = new Dependente(12, "Douglas", 33);

a1.AdicionarDependente(dep1);
a1.AdicionarDependente(dep2);
a1.AdicionarDependente(dep3);
a2.AdicionarDependente(dep4);
a2.AdicionarDependente(dep5);
a2.AdicionarDependente(dep6);
c1.AdicionarDependente(dep7);
c1.AdicionarDependente(dep8);
c1.AdicionarDependente(dep9);
c2.AdicionarDependente(dep10);
c2.AdicionarDependente(dep11);
c2.AdicionarDependente(dep12);

System.Console.WriteLine("------------------- DEPENDENTES ----------------");
a1.MostrarDependentes();
a2.MostrarDependentes();
c1.MostrarDependentes();
c2.MostrarDependentes();

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

d1.MostrarQtdeDependentesFuncionarios();
d2.MostrarQtdeDependentesFuncionarios();

a1.removerDependente(2);
a2.removerDependente(5);
c1.removerDependente(8);
c2.removerDependente(11);

System.Console.WriteLine("----------------- DEPENDENTES -----------------");
a1.MostrarDependentes();
a2.MostrarDependentes();
c1.MostrarDependentes();
c2.MostrarDependentes();

d1.MostrarQtdeDependentesFuncionarios();
d2.MostrarQtdeDependentesFuncionarios();

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




