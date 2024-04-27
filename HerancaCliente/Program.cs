using HerancaCliente;

Cliente c = new Cliente();
c.Codigo = 1;
c.Nome = "Fatec";
c.Endereco = "Rua Teresina, 75";

ClienteFisico cf = new ClienteFisico();
cf.Codigo = 2;
cf.Nome = "Ana";
cf.Endereco = "Rua Centro, 2";
cf.Rg = "123456789";
cf.Mostrar();

ClienteFisico cf2 = new ClienteFisico(4, "Prudentino", "Rua Periferia, 10", "5235315");
cf2.Mostrar();

ClienteJuridico cj = new ClienteJuridico();
cj.Codigo = 3;
cj.Nome = "Doug";
cj.Endereco = "Rua Teste, 10";
cj.Cnpj = "123456789-0001";

ClienteJuridico cj2 = new ClienteJuridico(5, "Empresa", "Rua Teste 20", "1231241212-0001");
cj2.Mostrar();

