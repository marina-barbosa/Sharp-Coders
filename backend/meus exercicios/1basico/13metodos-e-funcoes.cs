


// Métodos em C#:
// 1. Como criar um método:
// Neste exemplo, temos um método chamado MeuMetodo que imprime uma mensagem. O método Main é o ponto de entrada do programa.
class Program
{
    // Método principal (ponto de entrada do programa)
    static void Main()
    {
        // Chama outro método
        MeuMetodo();
    }

    // Outro método que criamos
    static void MeuMetodo()
    {
        Console.WriteLine("Olá! Eu sou um método em C#.");
    }
}





// 2. Parâmetros:
// Aqui, o método Saudacao recebe um parâmetro nome e imprime uma saudação personalizada.
class Program
{
    static void Main()
    {
        // Chamando um método com parâmetro
        Saudacao("João");
    }

    // Método com parâmetro
    static void Saudacao(string nome)
    {
        Console.WriteLine("Olá, " + nome + "!");
    }
}

// 3. Retorno de Função:
// O método Somar recebe dois parâmetros, realiza a soma e retorna o resultado.
class Program
{
    static void Main()
    {
        // Chamando um método que retorna um valor
        int resultado = Somar(5, 3);
        Console.WriteLine("A soma é: " + resultado);
    }

    // Método que retorna um valor
    static int Somar(int a, int b)
    {
        return a + b;
    }
}


