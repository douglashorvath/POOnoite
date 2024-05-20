using TrabalhoPolimorfismo;

Funcionario funcionario = new Funcionario(1010, "Funcionario", 1000);
Secretario secretario = new Secretario(1020, "Secretario", 1500);
Gerente gerente = new Gerente(2020, "Gerente", 2000);
Diretor diretor = new Diretor(2040, "Diretor", 4000);

GerenciarBonificacao gb = new GerenciarBonificacao();
gb.TotalizadorBonificacao(funcionario);
gb.TotalizadorBonificacao(secretario);
gb.TotalizadorBonificacao(gerente);
gb.TotalizadorBonificacao(diretor);

System.Console.WriteLine("Total de bonificação: " + gb.TotalBonificacao);

