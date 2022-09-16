using ExemploFundamentos.Models;
using OperadoresAritmeticosCSharp.Models;


int [] arrayInteiros = new int[3];
arrayInteiros [0] = 72;
arrayInteiros [1] = 64;
arrayInteiros [2] = 50;
arrayInteiros[3] = 10;

for(int contador = 0; contador < 3; contador ++)
  Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]}");





















//Calculadora  calc = new Calculadora();


// calc.Somar(10,30);
// calc.Subtrair(10,50);
// calc.Multiplicar(15,45);
// calc.Dividir(2,2);
//calc.Potencia(3,3);
// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);

// int numeroIncremento = 10;
// Console.WriteLine(numeroIncremento);
// Console.WriteLine("Incrementando o 10");
// // numero = numero + 1;
// numeroIncremento++;
// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 20;
// Console.WriteLine("Decrementando o 20");
// // numero = numero + 1;
// numeroDecremento--;
// Console.WriteLine(numeroDecremento);

//calc.RaizQuadrada(9);




















// bool choveu = false;
// bool estaTarde = true;

// if(!choveu && ! estaTarde){

//       Console.WriteLine("Vou pedalar");

// }
// else{

//       Console.WriteLine("Vou  pedalar um outro dia.");

// }










// bool possuiPresencaMinima = true;

// double media =5.5;

// if(possuiPresencaMinima && media >= 7){

//       Console.WriteLine("Aprovado");


// }else{

//       Console.WriteLine("Reprovado");

// }















// bool ehMaiorDeIdade = false;
// bool possuiAutorizacaoDoUsuario = false;

// if(ehMaiorDeIdade || possuiAutorizacaoDoUsuario){

//       Console.WriteLine("Entrada liberada");

// }
// else{

//       Console.WriteLine("Entrada não liberada");

// }











// Console.WriteLine("Digite uma letra:  ");
// string letra = Console.ReadLine();

// switch (letra)
// {
//       case "a":
//       case "e":
//       case "i":
//       case "o":
//       case "u":
//             Console.WriteLine("Vogal");
//             break;
      
//       default:
//             Console.WriteLine("Não é uma vogal");
//             break;

// }


















// if(letra == "a" || letra == "e"
//    letra == "i" || letra == "o" 
//    || letra == "u") {

//       Console.WriteLine("Vogal");

// }
// else{

//       Console.WriteLine("Não é uma vogal");

// }





















// if(letra == "a"){

//        Console.Writeline("vogal");

// }else if(letra == "e"){

//        Console.Writeline("vogal");

// }else if(letra == "i"){

//        Console.Writeline("vogal");

// }else if(letra == "o){

//        Console.Writeline("vogal");

// } else if(letra == "u"){

//       Console.Writeline("vogal");

// }else{

//       Console.Writeline("Não é umavogal");

// }












// int quantidadeEmEstoque = 3;

// int quantidadeCompra = 0;

// bool possivelVenda = quantidadeCompra > 0  && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque:  {quantidadeEmEstoque} ");
// Console.WriteLine($"Quantidade compra:  {quantidadeCompra} ");
// Console.WriteLine($"É possível realizar a venda?  {possivelVenda}");


// if(quantidadeCompra == 0){

//       Console.WriteLine("Venda inválida");

// }
// else if(possivelVenda)
// {

//       Console.WriteLine("Venda realizada.");


// }
// else
// {
  
//       Console.WriteLine("Desculpe não temos a quantidade desejada em estoque");

// }








// string a = "15-";

// //int b =0;

// int.TryParse(a, out int b);

// Console.WriteLine(b);

// Console.WriteLine("Conversão realizada com sucesso");


// double a = 4/ (2 + 2);

// Console.WriteLine(a);


// int a = 5;

// double b = a;

// long a = long.MaxValue;

// long b = Convert.ToInt32(a);

// int a = int.MaxValue;

// long b = a;

// Console.WriteLine(b);


// int a =  10;

// int  b = 20;

// int c = a + b;

//c = c +  5; // 30 + 5

//c += 5;  // c = c + 5

//c -= 5; // c = c -- 5

//c *= 5;



//Console.WriteLine(c);

//Cast  -  Casting
//int a = Convert.ToInt32(null); // Retorna 0 ao passar o valor nulo como parâmetro. Preferíel de utilizar. Cenário  de valor nulo é comum.

//int a = int.Parse(null); // Não aceita nulo

// int inteiro = 5;
// string a =   inteiro.ToString();

// Console.WriteLine(a);





















// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


















// string apresentacao = "Olá, seja bem vindo";

// int quantidade = 1;

// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// quantidade = 10;

// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// double altura = 1.80;

// decimal preco =1.80M;

// bool condicao = true;

// Console.WriteLine("Valor da variável apresentacao: " + apresentacao);

// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));

// Console.WriteLine("Valor da variável preco: " + preco);

// Console.WriteLine("Valor da variável condicao: " + condicao);



/*Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Buta";
pessoa1.Idade = 26;
pessoa1.Apresentar();

Pessoa pessoaFisicaRepresentacao = new Pessoa();*/




