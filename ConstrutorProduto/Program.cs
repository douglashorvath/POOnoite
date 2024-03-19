using ConstrutorProduto;

Produto p1 = new Produto();
p1.MostrarAtributos();

Produto p2 = new Produto(666);
p2.MostrarAtributos();

Produto p3 = new Produto(333,"meio besta",1000);
p3.MostrarAtributos();

System.Console.WriteLine("Número de instâncias: "+Produto.Instancias);