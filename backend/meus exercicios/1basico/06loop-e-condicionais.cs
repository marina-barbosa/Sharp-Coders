
// Lembre-se de incluir using System; no início do seu arquivo para utilizar as funcionalidades de entrada e saída padrão (Console).

using System;

// Estruturas Condicionais:

// if, else:

// O if é usado para executar um bloco de código se a condição fornecida for verdadeira. O else é opcional e é executado se a condição do if for falsa.


int idade = 18;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}



// switch:

// O switch é usado para selecionar um dos muitos blocos de código para serem executados.


int opcao = 2;

switch (opcao)
{
    case 1:
        Console.WriteLine("Opção 1 selecionada.");
        break;
    case 2:
        Console.WriteLine("Opção 2 selecionada.");
        break;
    default:
        Console.WriteLine("Opção padrão.");
        break;
}



// Loops:


// for:

// O for é usado para repetir um bloco de código um número conhecido de vezes.


for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Contagem: {i}");
}


// while:

// O while é usado para repetir um bloco de código enquanto uma condição específica for verdadeira.


int contador = 0;

while (contador < 3)
{
    Console.WriteLine($"Contagem: {contador}");
    contador++;
}


// do-while:

// O do-while é semelhante ao while, mas garante que o bloco de código seja executado pelo menos uma vez antes de verificar a condição.


int numero;
do
{
    Console.WriteLine("Digite um número positivo:");
} while (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0);

Console.WriteLine($"Você digitou: {numero}");

