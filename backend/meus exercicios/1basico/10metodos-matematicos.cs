using System;

class Program
{
    static void Main()
    {
        double num1 = 10.5;
        double num2 = 5.2;

        // 1. Adição
        double soma = num1 + num2;

        // 2. Subtração
        double subtracao = num1 - num2;

        // 3. Multiplicação
        double multiplicacao = num1 * num2;

        // 4. Divisão
        double divisao = num1 / num2;

        // 5. Módulo (resto da divisão)
        double modulo = num1 % num2;

        // 6. Incremento
        num1++;

        // 7. Decremento
        num2--;

        // 8. Potência
        double potencia = Math.Pow(num1, 2);

        // 9. Raiz quadrada
        double raizQuadrada = Math.Sqrt(num1);

        // 10. Valor absoluto
        double valorAbsoluto = Math.Abs(-10);

        // 11. Arredondamento para cima
        double arredondaCima = Math.Ceiling(10.3);

        // 12. Arredondamento para baixo
        double arredondaBaixo = Math.Floor(10.8);

        // 13. Arredondamento para o valor mais próximo
        double arredondaMaisProximo = Math.Round(10.5);

        // 14. Seno
        double seno = Math.Sin(Math.PI / 2);

        // 15. Cosseno
        double cosseno = Math.Cos(Math.PI);

        // 16. Tangente
        double tangente = Math.Tan(Math.PI / 4);

        // 17. Arcoseno
        double arcoseno = Math.Asin(0.5);

        // 18. Arcocosseno
        double arcocosseno = Math.Acos(0.5);

        // 19. Arcotangente
        double arcotangente = Math.Atan(1);

        // 20. Logaritmo natural
        double logNatural = Math.Log(num1);

        // 21. Logaritmo na base 10
        double logBase10 = Math.Log10(num1);

        // 22. Máximo entre dois números
        double maximo = Math.Max(num1, num2);

        // 23. Mínimo entre dois números
        double minimo = Math.Min(num1, num2);

        // 24. Truncate - Remove a parte fracionária de um número
        double truncado = Math.Truncate(10.9);

        // 25. Abs - Retorna o valor absoluto de um número
        double abs = Math.Abs(-5.6);

        // 26. Pow - Eleva um número a uma potência específica
        double potencia2 = Math.Pow(2, 3);

        // 27. Exp - Retorna e elevado à potência de um número especificado
        double exp = Math.Exp(1);

        // 28. Floor - Retorna o maior número inteiro menor ou igual a um número de ponto flutuante
        double floor = Math.Floor(10.9);

        // 29. Ceiling - Retorna o menor número inteiro maior ou igual a um número de ponto flutuante
        double ceiling = Math.Ceiling(10.1);

        // 30. Round - Arredonda um número de ponto flutuante para o valor inteiro mais próximo
        double round = Math.Round(10.5);

        // Exibindo resultados
        Console.WriteLine(soma);
        Console.WriteLine(subtracao);
        Console.WriteLine(multiplicacao);
        Console.WriteLine(divisao);
        Console.WriteLine(modulo);
        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(potencia);
        Console.WriteLine(raizQuadrada);
        Console.WriteLine(valorAbsoluto);
        Console.WriteLine(arredondaCima);
        Console.WriteLine(arredondaBaixo);
        Console.WriteLine(arredondaMaisProximo);
        Console.WriteLine(seno);
        Console.WriteLine(cosseno);
        Console.WriteLine(tangente);
        Console.WriteLine(arcoseno);
        Console.WriteLine(arcocosseno);
        Console.WriteLine(arcotangente);
        Console.WriteLine(logNatural);
        Console.WriteLine(logBase10);
        Console.WriteLine(maximo);
        Console.WriteLine(minimo);
        Console.WriteLine(truncado);
        Console.WriteLine(abs);
        Console.WriteLine(potencia2);
        Console.WriteLine(exp);
        Console.WriteLine(floor);
        Console.WriteLine(ceiling);
        Console.WriteLine(round);
    }
}
