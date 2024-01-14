using System;

class Program
{
    static void Main()
    {
        string texto = "Hello, World!";

        // 1. Concatenação de strings
        string concatenado = texto + " Greetings";

        // 2. Método Concat
        string concat = string.Concat(texto, " Greetings");

        // 3. Interpolação de strings
        string interpolado = $"{texto} Greetings";

        // 4. Length - Retorna o comprimento da string
        int length = texto.Length;

        // 5. ToUpper - Converte a string para maiúsculas
        string upper = texto.ToUpper();

        // 6. ToLower - Converte a string para minúsculas
        string lower = texto.ToLower();

        // 7. Substring - Obtém uma substring com base no índice inicial
        string substring = texto.Substring(7);

        // 8. IndexOf - Retorna o índice da primeira ocorrência de um caractere ou substring
        int indexOf = texto.IndexOf("World");

        // 9. LastIndexOf - Retorna o índice da última ocorrência de um caractere ou substring
        int lastIndexOf = texto.LastIndexOf("l");

        // 10. Replace - Substitui todas as ocorrências de um caractere ou substring
        string replaced = texto.Replace("Hello", "Hi");

        // 11. Trim - Remove espaços em branco do início e do final da string
        string trimmed = texto.Trim();

        // 12. StartsWith - Verifica se a string começa com um determinado prefixo
        bool startsWith = texto.StartsWith("Hello");

        // 13. EndsWith - Verifica se a string termina com um determinado sufixo
        bool endsWith = texto.EndsWith("World!");

        // 14. Contains - Verifica se a string contém uma determinada substring
        bool contains = texto.Contains("lo, W");

        // 15. IsNullOrEmpty - Verifica se a string é nula ou vazia
        bool isNullOrEmpty = string.IsNullOrEmpty(texto);

        // 16. IsNullOrWhiteSpace - Verifica se a string é nula, vazia ou consiste apenas de espaços em branco
        bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(texto);

        // 17. Split - Divide a string em um array de substrings com base em um delimitador
        string[] split = texto.Split(',');

        // 18. Join - Concatena um array de strings usando um separador
        string joined = string.Join(" ", split);

        // 19. Compare - Compara duas strings e retorna um valor que indica a relação entre elas
        int compareResult = string.Compare(texto, "Hello, World!");

        // 20. Equals - Verifica se duas strings são iguais
        bool areEqual = texto.Equals("Hello, World!");

        // 21. ToCharArray - Converte a string em um array de caracteres
        char[] charArray = texto.ToCharArray();

        // 22. PadLeft - Preenche a string com espaços à esquerda até atingir o comprimento desejado
        string padLeft = texto.PadLeft(20);

        // 23. PadRight - Preenche a string com espaços à direita até atingir o comprimento desejado
        string padRight = texto.PadRight(20);

        // 24. Format - Formata uma string com base em um formato e argumentos
        string formatted = string.Format("O texto é: {0}", texto);

        // 25. ToInt32 - Converte a string em um número inteiro
        int intValue = Convert.ToInt32("123");

        // 26. ToDouble - Converte a string em um número de ponto flutuante
        double doubleValue = Convert.ToDouble("123.45");

        // 27. Substring com índice de início e comprimento
        string substringLength = texto.Substring(7, 5);

        // 28. Remove - Remove uma parte da string com base no índice e no comprimento
        string removed = texto.Remove(7, 5);

        // 29. Insert - Insere uma substring em uma posição específica
        string inserted = texto.Insert(7, " Awesome");

        // 30. ToCharArray - Converte a string em um array de caracteres
        char[] charArray2 = texto.ToCharArray();

        // Exibindo resultados
        Console.WriteLine(concatenado);
        Console.WriteLine(concat);
        Console.WriteLine(interpolado);
        Console.WriteLine(length);
        Console.WriteLine(upper);
        Console.WriteLine(lower);
        Console.WriteLine(substring);
        Console.WriteLine(indexOf);
        Console.WriteLine(lastIndexOf);
        Console.WriteLine(replaced);
        Console.WriteLine(trimmed);
        Console.WriteLine(startsWith);
        Console.WriteLine(endsWith);
        Console.WriteLine(contains);
        Console.WriteLine(isNullOrEmpty);
        Console.WriteLine(isNullOrWhiteSpace);
        Console.WriteLine(string.Join(", ", split));
        Console.WriteLine(joined);
        Console.WriteLine(compareResult);
        Console.WriteLine(areEqual);
        Console.WriteLine(charArray);
        Console.WriteLine(padLeft);
        Console.WriteLine(padRight);
        Console.WriteLine(formatted);
        Console.WriteLine(intValue);
        Console.WriteLine(doubleValue);
        Console.WriteLine(substringLength);
        Console.WriteLine(removed);
        Console.WriteLine(inserted);
        Console.WriteLine(charArray2);
    }
}
