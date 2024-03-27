

// Aqui estão alguns dos métodos mais comuns para manipulação de arrays e coleções em C#:
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Add: Adiciona um elemento ao final da coleção.
        List<int> list = new List<int>();
        list.Add(1);

        // 2. Remove: Remove a primeira ocorrência do elemento especificado.
        list.Remove(1);

        // 3. Clear: Remove todos os elementos da coleção.
        list.Clear();

        // 4. Contains: Verifica se a coleção contém um determinado elemento.
        bool containsElement = list.Contains(1);

        // 5. Count: Retorna o número de elementos na coleção.
        int count = list.Count;

        // 6. IndexOf: Retorna o índice da primeira ocorrência de um elemento.
        int indexOfElement = list.IndexOf(1);

        // 7. Insert: Insere um elemento em um índice específico.
        list.Insert(0, 42);

        // 8. RemoveAt: Remove o elemento no índice especificado.
        list.RemoveAt(0);

        // 9. ToArray: Converte a lista em um array.
        int[] array = list.ToArray();

        // 10. Sort: Ordena os elementos na coleção.
        list.Sort();

        // 11. Reverse: Inverte a ordem dos elementos na coleção.
        list.Reverse();

        // 12. CopyTo: Copia os elementos da coleção para um array, começando em um índice específico.
        int[] destinationArray = new int[5];
        list.CopyTo(destinationArray, 1);

        // 13. TrimExcess: Define a capacidade da lista para o número real de elementos.
        list.TrimExcess();

        // 14. Exists: Determina se um elemento na coleção atende a uma condição específica.
        bool exists = list.Exists(x => x > 10);

        // 15. Find: Retorna o primeiro elemento que atende a uma condição específica.
        int foundElement = list.Find(x => x > 10);

        // 16. FindAll: Retorna todos os elementos que atendem a uma condição específica.
        List<int> foundElements = list.FindAll(x => x > 10);

        // 17. ForEach: Executa uma ação em cada elemento da coleção.
        list.ForEach(x => Console.WriteLine(x));

        // 18. ConvertAll: Converte todos os elementos da coleção para outro tipo.
        List<string> stringList = list.ConvertAll(x => x.ToString());

        // 19. TrueForAll: Determina se todos os elementos da coleção atendem a uma condição específica.
        bool allGreaterThanZero = list.TrueForAll(x => x > 0);

        // 20. AddRange: Adiciona os elementos de uma coleção à coleção atual.
        list.AddRange(new List<int> { 1, 2, 3 });

        // 21. FindIndex: Retorna o índice do primeiro elemento que atende a uma condição específica.
        int index = list.FindIndex(x => x > 10);

        // 22. FindLast: Retorna o último elemento que atende a uma condição específica.
        int lastElement = list.FindLast(x => x > 10);

        // 23. FindLastIndex: Retorna o índice do último elemento que atende a uma condição específica.
        int lastIndex = list.FindLastIndex(x => x > 10);

        // 24. GetRange: Retorna uma nova lista que contém os elementos no intervalo especificado.
        List<int> rangeList = list.GetRange(1, 2);

        // 25. InsertRange: Insere os elementos de uma coleção no índice especificado.
        list.InsertRange(1, new List<int> { 4, 5 });

        // 26. RemoveAll: Remove todos os elementos que atendem a uma condição específica.
        list.RemoveAll(x => x > 10);

        // 27. RemoveRange: Remove uma quantidade específica de elementos a partir de um índice específico.
        list.RemoveRange(1, 2);

        // 28. BinarySearch: Pesquisa binária na lista ordenada.
        int binarySearchResult = list.BinarySearch(5);

        // 29. AsReadOnly: Retorna uma versão somente leitura da lista.
        IList<int> readOnlyList = list.AsReadOnly();

        // 30. GetEnumerator: Obtém um enumerador para a lista.
        IEnumerator<int> enumerator = list.GetEnumerator();

        // Where(filter): Retorna uma nova coleção contendo apenas os elementos que atendem a uma condição específica.
        List<int> filteredList = list.Where(x => x > 10).ToList();

        // Replace: Substitui todas as ocorrências de um valor por outro em uma string.
        string replacedString = originalString.Replace("oldValue", "newValue");

        // Select(map): Projeta cada elemento de uma coleção para um novo formulário.
        List<string> mappedList = list.Select(x => x.ToString()).ToList();

        // Split: Divide uma string em substrings com base em um delimitador.
        string[] substrings = inputString.Split(',');

        // RemoveRange(splice): Remove uma quantidade específica de elementos a partir de um índice específico em uma lista.
        list.RemoveRange(startIndex, count);

    }
}