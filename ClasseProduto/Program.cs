// See https://aka.ms/new-console-template for more information

using ClasseProduto;



Produto produto1 = new Produto();

System.Console.WriteLine("Digite o código:");
produto1.codigo = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Digite o nome: ");
produto1.nome = Console.ReadLine();
System.Console.WriteLine("Digite o preço:");
produto1.preco = Convert.ToDouble(Console.ReadLine());

produto1.MostrarAtributos();

System.Console.WriteLine("Digite a porcentagem de aumento: ");
double perc = Convert.ToDouble(Console.ReadLine());
produto1.AumentarValor(perc);
produto1.MostrarAtributos();


// List<Produto> produtos = new List<Produto>();
// int opt = -1;
// while(opt  != 0)
// {
//     System.Console.WriteLine("------ Menu ------");
//     System.Console.WriteLine("1 - Cadastrar Produto");
//     System.Console.WriteLine("2 - Ver Produtos");
//     opt = Convert.ToInt32(Console.ReadLine());
//     switch(opt)
//     {
//         case 1: 
//             Produto produto1 = new Produto();
//             System.Console.WriteLine("Digite o cõdigo:");
//             produto1.codigo = Convert.ToInt32(Console.ReadLine());
//             System.Console.WriteLine("Digite o nome: ");
//             produto1.nome = Console.ReadLine();
//             System.Console.WriteLine("Digite o preço:");
//             produto1.preco = Convert.ToDouble(Console.ReadLine());
//             produtos.Add(produto1);
//             break;
//         case 2:
//             foreach(Produto p in produtos){
//                 p.MostrarAtributos();
//             }
//             break;
            
//     }
// }

