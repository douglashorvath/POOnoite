// See https://aka.ms/new-console-template for more information

using ClasseProduto;

Produto produto1 = new Produto();
produto1.codigo = 123;
produto1.nome = "Papel";
produto1.preco = 15.5;

produto1.MostrarAtributos();

System.Console.WriteLine("Digite a porcentagem de aumento: ");
double perc = Convert.ToDouble(Console.ReadLine());
produto1.AumentarValor(perc);
produto1.MostrarAtributos();

