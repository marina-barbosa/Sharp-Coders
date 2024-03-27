
using System.Globalization;

namespace Lista01;

public class Program
{
    public static void Main()
    {
        // Fliper_2425();
        // Tabuada_1078();
        // SequenciaNumerosSoma_1101();
        // FatorialSimples_1153();
        // NumeroPrimo_1165();
        // CoordenadasDeUmPonto_1041();
        // ColunaNaMatriz_1182();
        // Huaaauhahhuahau_2242();
        // CampoMinado_2399();
        // LinhaNaMatriz_1181();

    }

    private static void Fliper_2425()
    {
        // string entrada = "1 0";
        string[] entrada = Console.ReadLine().Split(' ');

        if (entrada == null)
        {
            return;
        }

        if (entrada[0] == "0")
        {
            Console.WriteLine("C");
        }
        else if (entrada[0] == "1" && entrada[1] == "0")
        {
            Console.WriteLine("B");
        }
        else
        {
            Console.WriteLine("A");
        }
    }

    private static void Tabuada_1078()
    {
        int entrada = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} x {entrada} = {i * entrada}");
        }
    }

    private static void SequenciaNumerosSoma_1101()
    {
        while (true)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int a = int.Parse(entrada[0]);
            int b = int.Parse(entrada[1]);

            if (a <= 0 || b <= 0)
            {
                return;
            }

            int fim;
            int inicio;

            if (a < b)
            {
                inicio = a;
                fim = b;
            }
            else
            {
                inicio = b;
                fim = a;
            }

            string saida = "";
            int soma = 0;

            for (int i = inicio; i <= fim; i++)
            {
                saida += $"{i} ";
                soma += i;
            }

            saida += $"Sum={soma}";
            Console.WriteLine(saida);
        }

    }

    private static void FatorialSimples_1153()
    {
        int entrada = int.Parse(Console.ReadLine());
        int fatorial = entrada;
        for (int i = entrada - 1; i > 0; i--)
        {
            fatorial *= i;
        }
        Console.WriteLine(fatorial);
    }

    private static void NumeroPrimo_1165()
    {
        int entrada = int.Parse(Console.ReadLine());
        bool primo;

        for (int i = 0; i < entrada; i++)
        {
            primo = true;
            int caso = int.Parse(Console.ReadLine());

            for (int j = 2; j < caso; j++)
            {
                if (caso % j == 0)
                {
                    primo = false;
                    break;
                }
            }

            if (primo && caso > 1)
            {
                Console.WriteLine($"{caso} eh primo");
            }
            else
            {
                Console.WriteLine($"{caso} nao eh primo");
            }
        }
        return;
    }

    private static void CoordenadasDeUmPonto_1041()
    {
        string[] entrada = Console.ReadLine().Split(' ');

        double x = double.Parse(entrada[0]);
        double y = double.Parse(entrada[1]);

        if (x == 0.0 && y == 0.0)
        {
            Console.WriteLine("Origem");
            return;
        }
        else if (x == 0.0)
        {
            Console.WriteLine("Eixo Y");
            return;
        }
        else if (y == 0.0)
        {
            Console.WriteLine("Eixo X");
            return;
        }
        else if (x > 0.0 && y > 0.0)
        {
            Console.WriteLine("Q1");
            return;
        }
        else if (x < 0.0 && y > 0.0)
        {
            Console.WriteLine("Q2");
            return;
        }
        else if (x < 0.0 && y < 0.0)
        {
            Console.WriteLine("Q3");
            return;
        }
        else
        {
            Console.WriteLine("Q4");
            return;
        }

    }

    private static void ColunaNaMatriz_1182()
    {
        double soma = 0.0;
        double media;
        string coluna = Console.ReadLine();
        string operacao = Console.ReadLine();
        string num;
        string resFormatada;

        int col = int.Parse(coluna);

        for (int l = 0; l < 12; l++)
        {
            for (int c = 0; c < 12; c++)
            {
                num = Console.ReadLine();
                if (c == col)
                {
                    soma += double.Parse(num);
                }
            }
        }

        if (operacao == "M")
        {
            media = soma / 12;
            resFormatada = media.ToString("F1", CultureInfo.InvariantCulture);
            Console.WriteLine(resFormatada);
        }
        else
        {
            resFormatada = soma.ToString("F1", CultureInfo.InvariantCulture);
            Console.WriteLine(resFormatada);
        }
        return;

    }

    private static void Huaaauhahhuahau_2242()
    {
        // string entrada = "huaauhahhuahau"; // S 
        string entrada = Console.ReadLine();
        string vogais = "aeiou";

        char[] vogaisNaEntrada = entrada.Where(letra => vogais.Contains(letra)).ToArray();

        char[] invertida = vogaisNaEntrada.Reverse().ToArray();

        Console.WriteLine(vogaisNaEntrada.SequenceEqual(invertida) ? "S" : "N");

    }

    private static void CampoMinado_2399()
    {

        int num = int.Parse(Console.ReadLine());
        List<int> tabuleiro = new List<int>();

        if (num == 0)
        {
            return;
        }

        for (int j = 0; j < num; j++)
        {
            tabuleiro.Add(int.Parse(Console.ReadLine()));
        }

        if (num == 1)
        {
            Console.WriteLine(tabuleiro[0]);
            return;
        }

        if (num == 2)
        {
            Console.WriteLine(tabuleiro[0] + tabuleiro[1]);
            Console.WriteLine(tabuleiro[1] + tabuleiro[0]);
        }

        for (int i = 0; i < num; i++)
        {
            int minas;
            if (i == 0)
            {
                minas = tabuleiro[i] + tabuleiro[i + 1];
                Console.WriteLine(minas);
            }
            else if (i == num - 1)
            {
                minas = tabuleiro[i - 1] + tabuleiro[i];
                Console.WriteLine(minas);
            }
            else
            {
                minas = tabuleiro[i - 1] + tabuleiro[i] + tabuleiro[i + 1];
                Console.WriteLine(minas);
            }
        }
        return;
    }

    private static void LinhaNaMatriz_1181()
    {
        double soma = 0.0;
        double media;
        string lin = Console.ReadLine();
        string operacao = Console.ReadLine();
        string num;
        string resFormatada;

        int linha = int.Parse(lin);

        for (int l = 0; l < 12; l++)
        {
            for (int c = 0; c < 12; c++)
            {
                num = Console.ReadLine();
                if (l == linha)
                {
                    soma += double.Parse(num);
                }
            }
        }

        if (operacao == "M")
        {
            media = soma / 12;
            resFormatada = media.ToString("F1", CultureInfo.InvariantCulture);
            Console.WriteLine(resFormatada);
        }
        else
        {
            resFormatada = soma.ToString("F1", CultureInfo.InvariantCulture);
            Console.WriteLine(resFormatada);
        }
        return;
    }
}


