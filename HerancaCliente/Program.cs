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

ClienteJuridico cj = new ClienteJuridico();
