using EncapsulamentoFuncionario;

Funcionario[] funcionarios = new Funcionario[3];

for(int i=0;i<funcionarios.Length;i++)
{
    funcionarios[i] = new Funcionario();
    System.Console.WriteLine("Digite o código:");
    funcionarios[i].Codigo = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Digite o nome: ");
    funcionarios[i].Nome = Console.ReadLine();
    System.Console.WriteLine("Digite o salário:");
    funcionarios[i].Salario = Convert.ToDouble(Console.ReadLine());
}

foreach(Funcionario f in funcionarios)
{
    f.MostrarAtributos();
}