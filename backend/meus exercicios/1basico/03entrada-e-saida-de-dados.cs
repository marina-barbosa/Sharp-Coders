// Em C#, a entrada e saída de dados são realizadas principalmente por meio das classes presentes no namespace System. 



// Lembre-se de importar o namespace System no início do seu código:
using System;



// Entrada de Dados <<<<



// Console.ReadLine()
// Este método é usado para ler uma linha de texto do console.
Console.WriteLine("Digite algo:");
string input = Console.ReadLine();
Console.WriteLine("Você digitou: " + input);



// Console.Read()
// Lê o próximo caractere da entrada padrão.
Console.WriteLine("Digite um caractere:");
int charCode = Console.Read();
Console.WriteLine("Você digitou o caractere: " + (char)charCode);



// Convert.ToInt32(), Convert.ToDouble(), etc.
// Converte uma string para outros tipos de dados.
Console.WriteLine("Digite um número:");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);
Console.WriteLine("Você digitou o número: " + number);



// Saída de Dados <<<<



// Console.WriteLine()
// Exibe uma linha de texto no console.
Console.WriteLine("Olá, mundo!");



// Console.Write()
// Similar ao WriteLine, mas não adiciona uma nova linha no final.
Console.Write("Digite algo: ");
string input = Console.ReadLine();
Console.Write("Você digitou: " + input);



// String Interpolation
// Forma mais concisa de formatar strings.
string name = "João";
int age = 25;
Console.WriteLine($"Nome: {name}, Idade: {age}");


// Operações Básicas com Strings:

// Concatenação:
// Para juntar duas strings, você pode usar o operador + ou o método String.Concat().

string str1 = "Olá";
string str2 = " Mundo";
string resultado = str1 + str2; // Ou: string resultado = String.Concat(str1, str2);
Console.WriteLine(resultado); // Saída: Olá Mundo



// Comprimento da String:
// Para obter o comprimento de uma string, use a propriedade Length.

string minhaString = "Exemplo";
int comprimento = minhaString.Length;
Console.WriteLine(comprimento); // Saída: 7



// Acesso a caracteres individuais:
// Você pode acessar caracteres individuais de uma string usando o índice.

string minhaString = "Hello";
char primeiroCaracter = minhaString[0];
Console.WriteLine(primeiroCaracter); // Saída: H



// Comparação de Strings:
// // Para comparar strings, você pode usar o método String.Equals() ou os operadores de comparação (==, !=).

string str1 = "abc";
string str2 = "ABC";
bool saoIguais = String.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
Console.WriteLine(saoIguais); // Saída: True



// Formatação de Strings:



// Interpolação de String:
// // Utilizando o operador $ antes da string, você pode incorporar expressões diretamente dentro da string.

string nome = "João";
int idade = 25;
string mensagem = $"Olá, meu nome é {nome} e eu tenho {idade} anos.";
Console.WriteLine(mensagem); // Saída: Olá, meu nome é João e eu tenho 25 anos.



// String.Format:
// O método String.Format permite que você formate strings com espaços reservados.

string nome = "Maria";
int idade = 30;
string mensagem = String.Format("Olá, meu nome é {0} e eu tenho {1} anos.", nome, idade);
Console.WriteLine(mensagem); // Saída: Olá, meu nome é Maria e eu tenho 30 anos.



// Concatenação com Placeholders:
// Concatenar strings usando placeholders {0}, {1}, etc.

string nome = "Carlos";
int idade = 28;
string mensagem = "Olá, meu nome é " + nome + " e eu tenho " + idade + " anos.";
Console.WriteLine(mensagem); // Saída: Olá, meu nome é Carlos e eu tenho 28 anos.



