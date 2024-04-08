using TrabalhoAlunoConstrutor;


//.*.*.*.* TRABALHO, VALE 1 PONTO *.*.*.*.

//Data de entrega 31/03, pelo Teams, arquivo em .ZIP

//Criar os atributos matrícula, nome, p1, p2, media
//Criar os métodos/propriedade get e set, exceto o
//atributo média
//Criar o método para calcular a média do aluno
//O atributo matrícula não terá o método set, pois
//será gerado por um atributo static e armazenado
//no atributo matricula
//Não use vetor
//Crie o método MostrarAtributos, chame-o após cada
//instância
//Instancia no mínimo 4 objetos
    


//primeira instância
Aluno al1 = new Aluno();
al1.Nome = "José da Silva";
al1.P1 = 8;
al1.P2 = 9;
al1.CalcularMedia();
al1.MostrarAtributos();

//segunda instância
Aluno al2 = new Aluno();
al2.Nome = "João de Souza";
al2.P1 = 5;
al2.P2 = 6;
al2.CalcularMedia();
al2.MostrarAtributos();

//terceira instância
Aluno al3 = new Aluno();
al3.Nome = "Maria dos Santos";
al3.P1 = 10;
al3.P2 = 9;
al3.CalcularMedia();
al3.MostrarAtributos();

//quarta instância
Aluno al4 = new Aluno();
al4.Nome = "Ana Oliveira";
al4.P1 = 4;
al4.P2 = 3;
al4.CalcularMedia();
al4.MostrarAtributos();


//quinta instância, teste de erro de nome
Aluno al5 = new Aluno();
al4.Nome = "   ";

