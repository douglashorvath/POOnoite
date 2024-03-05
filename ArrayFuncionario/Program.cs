using ArrayFuncionario;

Funcionario[] funcionarios = new Funcionario[3];

for(int i=0;i<funcionarios.Length;i++)
{
    funcionarios[i] = new Funcionario();
    System.Console.WriteLine("Digite o código:");
    funcionarios[i].codigo = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Digite o nome: ");
    funcionarios[i].nome = Console.ReadLine();
    System.Console.WriteLine("Digite o salário:");
    funcionarios[i].salario = Convert.ToDouble(Console.ReadLine());
}

foreach(Funcionario f in funcionarios)
{
    f.MostrarAtributos();
}