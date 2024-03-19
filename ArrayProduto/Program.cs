using ArrayProduto;

List<Produto> produtos = new List<Produto>();

int opt = -1;

while(opt != 0)
{
    System.Console.WriteLine("Escolha uma opção:\n1.Cadastrar Produto\n2.Mostrar Produtos\n3.Aumentar Valores\n4.Remover Estoque");
    opt = Convert.ToInt32(Console.ReadLine());
    switch(opt){
        case 1: cadastrarProduto(); break;
        case 2: mostrarProdutos(); break;
        case 3: aumentarValor(); break;
        case 4: removerEstoque(); break;
    }
    
}

void cadastrarProduto(){
    Produto p = new Produto();
    System.Console.WriteLine("Digite o código:");
    p.codigo = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Digite o nome: ");
    p.nome = Console.ReadLine();
    System.Console.WriteLine("Digite o preço:");
    p.preco = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("Digite o estoque:");
    p.quantidade = Convert.ToInt32(Console.ReadLine());
    produtos.Add(p);
}

void mostrarProdutos(){
    foreach(Produto p in produtos)
    {
        p.MostrarAtributos();
    }
}

void aumentarValor()
{
    System.Console.WriteLine("Qual código do produto");
    int codigo = Convert.ToInt32(Console.ReadLine());
    foreach(Produto p in produtos)
    {
        if(p.codigo == codigo)
        {
            System.Console.WriteLine("Qual aumento");
            double aumento = Convert.ToDouble(Console.ReadLine());
            p.AumentarValor(aumento);
        }
    }
}

void removerEstoque()
{
    System.Console.WriteLine("Qual código do produto");
    int codigo = Convert.ToInt32(Console.ReadLine());
    foreach(Produto p in produtos)
    {
        if(p.codigo == codigo)
        {
            System.Console.WriteLine("Quandos produtos remover?");
            int rem = Convert.ToInt32(Console.ReadLine());
            if(p.quantidade >= rem)
            {
                p.RemoverEstoque(rem);
            }
            else{
                System.Console.WriteLine("Não há produtos suficientes");
            }
        }
    }
}
