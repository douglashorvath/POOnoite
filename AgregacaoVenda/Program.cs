using AgregacaoVenda;

// main

System.Console.WriteLine("---- Iniciar Venda ----");

Vendedor vendedor = new Vendedor();
vendedor.MostrarAtributos();
Comprador comprador = new Comprador();
comprador.Verba = 1000;
comprador.MostrarAtributos();

// cadastrar alguns produtos
System.Console.WriteLine("- Produtos -");

Produto p1 = new Produto("Camiseta", 80);
p1.MostrarAtributos();
Produto p2 = new Produto("Calça", 100);
p2.MostrarAtributos();
Produto p3 = new Produto("Blusa", 130);
p3.MostrarAtributos();
Produto p4 = new Produto("Tênis", 200);
p4.MostrarAtributos();
Produto p5 = new Produto("Meia", 20);
p5.MostrarAtributos();

System.Console.WriteLine("---- Iniciar Primeira Venda ----");

Venda venda = new Venda();
venda.Comp = comprador;
venda.Vend = vendedor;
venda.VetProd.Add(p1);
venda.VetProd.Add(p2);
venda.VetProd.Add(p3);
venda.VetProd.Add(p4);
venda.VetProd.Add(p5);
venda.calcularComissao();
venda.registraCompra(); 
venda.MostrarAtributos();


Venda venda2 = new Venda();
venda2.Comp = comprador;
venda2.Vend = vendedor;
venda2.VetProd.Add(p1);
venda2.VetProd.Add(p3);
venda2.VetProd.Add(p5);
venda2.calcularComissao();
venda2.registraCompra(); 
venda2.MostrarAtributos();

