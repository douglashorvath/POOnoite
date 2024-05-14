using AbstratoCliente;


//Cliente c = new Cliente(); //pobrema

ClienteFisico cf = new ClienteFisico(10, "John", "Rua das Flores, 10", 20,  "9891293");
cf.Mostrar();

ClienteJuridico cj = new ClienteJuridico(20, "Empresa", "Rua Teste, 10", 45, "1231241212-0001");
cj.Mostrar();

Teste t = new Teste();
t.VerificaIDade(cf);