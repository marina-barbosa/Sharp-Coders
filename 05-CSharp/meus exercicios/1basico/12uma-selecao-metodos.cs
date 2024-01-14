using System;

class Program
{
    static void Main()
    {
        // Exemplo de array de números
        int[] numeros = { 4, 2, 8, 6, 5, 1, 7, 3 };

        // Exemplo de string
        string texto = "C# é incrível!";

        // Métodos de array
        // 1. Ordenar um array
        Array.Sort(numeros);

        // 2. Inverter a ordem dos elementos em um array
        Array.Reverse(numeros);

        // 3. Encontrar o índice de um elemento em um array
        int indice = Array.IndexOf(numeros, 8);

        // 4. Verificar se um elemento existe em um array
        bool existe = Array.Exists(numeros, element => element == 5);

        // Métodos de string
        // 5. Dividir uma string em um array de substrings
        string[] partes = texto.Split(' ');

        // 6. Transformar uma string em maiúsculas
        string maiusculas = texto.ToUpper();

        // 7. Remover espaços em branco do início e do final da string
        string semEspacos = texto.Trim();

        // Métodos matemáticos
        // 8. Arredondar para o inteiro mais próximo
        double numeroDecimal = 7.8;
        int inteiroProximo = (int)Math.Round(numeroDecimal);

        // 9. Obter o valor absoluto
        int valorAbsoluto = Math.Abs(-10);

        // 10. Calcular o máximo entre dois números
        int maximo = Math.Max(15, 8);

        // Métodos de coleções
        // 11. Adicionar um elemento a uma lista
        var lista = new System.Collections.Generic.List<int>();
        lista.Add(42);

        // 12. Remover um elemento de uma lista
        lista.Remove(42);

        // 13. Contar elementos em uma lista
        int quantidadeElementos = lista.Count;

        // Métodos de conversão
        // 14. Converter uma string para um número inteiro
        int numeroConvertido = int.Parse("123");

        // 15. Converter um número inteiro para uma string
        string stringConvertida = numeroConvertido.ToString();

        // 16. Verificar se uma string é numérica
        bool ehNumerico = int.TryParse("42", out int resultado);

        // Métodos de data e hora
        // 17. Obter a data e hora atual
        DateTime agora = DateTime.Now;

        // 18. Adicionar dias a uma data
        DateTime daquiADias = agora.AddDays(7);

        // 19. Calcular a diferença entre duas datas
        TimeSpan diferenca = agora.Subtract(daquiADias);

        // Outros métodos úteis
        // 20. Imprimir no console
        Console.WriteLine("Olá, mundo!");

        // 21. Ler entrada do usuário
        string input = Console.ReadLine();

        // 22. Aguardar um tempo
        System.Threading.Thread.Sleep(1000);

        // 23. Gerar número aleatório
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        // 24. Verificar se um objeto é nulo
        object objeto = null;
        bool ehNulo = objeto == null;

        // 25. Operador condicional ternário
        int x = 5;
        int y = 10;
        int maior = (x > y) ? x : y;

        // 26. Operador de coalescência nula
        string nome = null;
        string nomeDefinido = nome ?? "Usuário";

        // 27. Iterar sobre uma coleção
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }

        // 28. Usar expressões lambda
        Func<int, int, int> somar = (a, b) => a + b;
        int resultadoSoma = somar(3, 4);

        // 29. Utilizar o operador de indexação
        string palavra = "Csharp";
        char primeiraLetra = palavra[0];

        // 30. Utilizar a instrução switch
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
    }
}
