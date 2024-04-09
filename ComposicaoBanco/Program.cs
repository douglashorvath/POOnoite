using ComposicaoBanco;
//Author: Douglas Horvath

/*Compactar o projeto em .ZIP e enviar pelo Teams
Seguir o diagrama de classes do slide 19 de Agregação e Composição
Criar as classes de acordo com o diagrama.
Use encapsulamento completo (com tratamento de valores digitados) para o atributo saldo da classe Poupança
Usar construtor
Realizar instâncias necessárias para testar as classes*/

//main

Banco banco = new Banco();
banco.IniciarBanco();

//adicionando algumas contas
banco.AbrirConta(1000,1000);
banco.AbrirConta(0,2000);
banco.AbrirConta(0,0);

//adicionando algumas poupanças
banco.AbrirPoupanca(1000);
banco.AbrirPoupanca(0);
banco.AbrirPoupanca(500);

banco.MostrarAtributos();

//adicionando rendimentos
foreach (Poupanca poupanca in banco.Poups){
    poupanca.GerarRendimento();
}


banco.MostrarAtributos();

//realizar alguns depositos aleatórios nas conta-correntes 
Random rand = new Random();

for(int i = 0; i < banco.Contas.Count; i++)
{
    int deposito = rand.Next(0,1000);
    
    System.Console.WriteLine($"Depositando {deposito:c}");
    banco.Contas[i].Depositar(deposito);
    banco.Contas[i].GerarExtrato();
    
}

banco.MostrarAtributos();

//realizar alguns saques aleatórios nas conta-correntes 
for(int i = 0; i < banco.Contas.Count; i++)
{
    int saque = rand.Next(0,1000);
    
    System.Console.WriteLine($"Sacando {saque:c}");
    if(banco.Contas[i].Sacar(saque))
        System.Console.WriteLine("Transação Realizada");
    else
        System.Console.WriteLine("Saldo/Limite indisponível");
    banco.Contas[i].GerarExtrato();
    
}

banco.MostrarAtributos();

//realizar alguns depositos aleatórios nas poupanças
for(int i = 0; i < banco.Poups.Count; i++)
{
    int deposito = rand.Next(0,1000);
    
    System.Console.WriteLine($"Depositando {deposito:c}");
    banco.Poups[i].Depositar(deposito);
    banco.Poups[i].MostrarAtributos();
}

banco.MostrarAtributos();


//decretar falência
banco.DecretarFalencia();

banco.MostrarAtributos();




