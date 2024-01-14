using System;

class Program
{
    static void Main()
    {
        // Métodos de conversão mais usados

        // 1. Conversão de string para int
        string strNumero = "123";
        int numeroConvertido = int.Parse(strNumero);

        // 2. Conversão de string para double
        string strNumeroDecimal = "45.67";
        double numeroDecimalConvertido = double.Parse(strNumeroDecimal);

        // 3. Conversão de string para bool
        string strBooleano = "True";
        bool booleanoConvertido = bool.Parse(strBooleano);

        // 4. Conversão de int para string
        int inteiro = 456;
        string strInteiro = inteiro.ToString();

        // 5. Conversão de double para string
        double numeroDouble = 78.9;
        string strDouble = numeroDouble.ToString();

        // 6. Conversão de bool para string
        bool valorBooleano = true;
        string strBooleano2 = valorBooleano.ToString();

        // 7. Conversão de string para DateTime
        string strData = "2022-01-14";
        DateTime dataConvertida = DateTime.Parse(strData);

        // 8. Conversão de DateTime para string
        DateTime dataHora = DateTime.Now;
        string strDataHora = dataHora.ToString("yyyy-MM-dd HH:mm:ss");

        // 9. Conversão de string para array de caracteres (char[])
        string strTexto = "C#";
        char[] arrayDeChars = strTexto.ToCharArray();

        // 10. Conversão de array de caracteres (char[]) para string
        char[] chars = { 'H', 'e', 'l', 'l', 'o' };
        string strFromCharArray = new string(chars);

        // 11. Conversão de string para enum
        string strEnum = "Segunda";
        DiaSemana diaEnum = (DiaSemana)Enum.Parse(typeof(DiaSemana), strEnum);

        // 12. Conversão de enum para string
        DiaSemana dia = DiaSemana.Quarta;
        string strFromEnum = dia.ToString();

        // 13. Conversão de string para int com verificação segura
        string strNumeroSeguro = "abc";
        int numeroConvertidoSeguro;
        bool conversaoSegura = int.TryParse(strNumeroSeguro, out numeroConvertidoSeguro);

        // 14. Conversão de string para double com verificação segura
        string strNumeroDoubleSeguro = "xyz";
        double numeroDoubleConvertidoSeguro;
        bool conversaoDoubleSegura = double.TryParse(strNumeroDoubleSeguro, out numeroDoubleConvertidoSeguro);

        // Exibindo resultados
        Console.WriteLine(numeroConvertido);
        Console.WriteLine(numeroDecimalConvertido);
        Console.WriteLine(booleanoConvertido);
        Console.WriteLine(strInteiro);
        Console.WriteLine(strDouble);
        Console.WriteLine(strBooleano2);
        Console.WriteLine(dataConvertida);
        Console.WriteLine(strDataHora);
        Console.WriteLine(arrayDeChars);
        Console.WriteLine(strFromCharArray);
        Console.WriteLine(diaEnum);
        Console.WriteLine(strFromEnum);
        Console.WriteLine(conversaoSegura ? numeroConvertidoSeguro.ToString() : "Conversão falhou");
        Console.WriteLine(conversaoDoubleSegura ? numeroDoubleConvertidoSeguro.ToString() : "Conversão falhou");
    }
}

// Enum para exemplo de conversão de string para enum
enum DiaSemana
{
    Segunda,
    Terca,
    Quarta,
    Quinta,
    Sexta,
    Sabado,
    Domingo
}
