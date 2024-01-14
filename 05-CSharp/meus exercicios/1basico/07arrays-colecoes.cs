

// Arrays Unidimensionais:
// Um array unidimensional é uma coleção de elementos do mesmo tipo, acessados por um índice. Aqui está um exemplo simples:

// Declaração e inicialização de um array unidimensional de inteiros
int[] arrayInteiros = new int[5] { 1, 2, 3, 4, 5 };

// Acessando elementos do array
Console.WriteLine(arrayInteiros[0]); // Saída: 1
Console.WriteLine(arrayInteiros[2]); // Saída: 3



// Arrays Multidimensionais:
// Arrays multidimensionais podem ter mais de uma dimensão. Vamos ver um exemplo de array bidimensional:


// Declaração e inicialização de um array bidimensional
int[,] arrayBidimensional = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

// Acessando elementos do array bidimensional
Console.WriteLine(arrayBidimensional[0, 1]); // Saída: 2
Console.WriteLine(arrayBidimensional[1, 2]); // Saída: 6



// Listas:
// Listas são coleções dinâmicas que podem crescer ou encolher durante a execução do programa. Aqui está um exemplo de lista:

// Importar o namespace System.Collections.Generic para usar List<T>
using System.Collections.Generic;

// Declaração e inicialização de uma lista de inteiros
List<int> listaInteiros = new List<int>() { 1, 2, 3, 4, 5 };

// Adicionando elementos à lista
listaInteiros.Add(6);

// Acessando elementos da lista
Console.WriteLine(listaInteiros[2]); // Saída: 3





// Dicionários:
// Dicionários são coleções de pares chave-valor. Cada elemento no dicionário tem uma chave única associada a um valor. Aqui está um exemplo:

// Declaração e inicialização de um dicionário
Dictionary<string, int> dicionario = new Dictionary<string, int>();

// Adicionando elementos ao dicionário
dicionario.Add("um", 1);
dicionario.Add("dois", 2);

// Acessando elementos do dicionário
Console.WriteLine(dicionario["um"]); // Saída: 1



// Conjuntos:
// Conjuntos são coleções que não permitem elementos duplicados. Aqui está um exemplo:

// Declaração e inicialização de um conjunto
HashSet<int> conjunto = new HashSet<int>() { 1, 2, 3, 4, 5 };

// Adicionando elementos ao conjunto
conjunto.Add(6);

// Verificando a existência de um elemento no conjunto
Console.WriteLine(conjunto.Contains(3)); // Saída: True