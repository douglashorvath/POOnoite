using AgregacaoConta;

//main

Cliente cli = new Cliente("Douglas", "455554555", "38948576877");
Endereco end = new Endereco ("Av. Brasil", 1000, "Presidente Prudente");
cli.EnderecoCliente = end;
Conta c1 = new Conta(cli, 123, 1000);
c1.MostrarAtributos();

