using ArrayProduto;

List<Produto> produtos = new List<Produto>;

for(int i=0;i<produtos.Length;i++)
{
    Produto p = new Produto();
    System.Console.WriteLine("Digite o código:");
    p.codigo = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Digite o nome: ");
    p.nome = Console.ReadLine();
    System.Console.WriteLine("Digite o preço:");
    p.preco = Convert.ToDouble(Console.ReadLine());
    produtos.Add(p);
}

foreach(Produto p in produtos)
{
    p.MostrarAtributos();
}

System.Console.WriteLine("Qual aumento geral?");
double aumento = Convert.ToDouble(Console.ReadLine());

foreach(Produto p in produtos)
{
    p.AumentarValor(aumento);
    p.MostrarAtributos();
}



