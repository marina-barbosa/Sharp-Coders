// Exemplos
int numeroInteiro = 42;
double numeroDecimal = 3.14;
string texto = "Olá, mundo!";
bool condicao = true;
char caractere = 'A';
float numeroDecimalMenosPreciso = 3.14f;
long numeroLongo = 1234567890123456789L;

// Uso das Variáveis
Console.WriteLine("Número Inteiro: " + numeroInteiro);
Console.WriteLine("Número Decimal: " + numeroDecimal);
Console.WriteLine("Texto: " + texto);
Console.WriteLine("Condição: " + condicao);
Console.WriteLine("Caractere: " + caractere);
Console.WriteLine("Número Decimal Menos Preciso: " + numeroDecimalMenosPreciso);
Console.WriteLine("Número Longo: " + numeroLongo);

// Extensão de cada Tipo
Console.WriteLine("Extensão do int: " + int.MinValue + " a " + int.MaxValue);
Console.WriteLine("Extensão do double: " + double.MinValue + " a " + double.MaxValue);
Console.WriteLine("Extensão do string: Sem limite prático, depende da memória disponível");
Console.WriteLine("Extensão do bool: Apenas dois valores possíveis, true ou false");
Console.WriteLine("Extensão do char: De 0 a 65535 (representando caracteres Unicode)");
Console.WriteLine("Extensão do float: " + float.MinValue + " a " + float.MaxValue);
Console.WriteLine("Extensão do long: " + long.MinValue + " a " + long.MaxValue);


// int: Representa números inteiros. Extensão: -2.147.483.648 a 2.147.483.647.

// double: Representa números de ponto flutuante. Extensão: ±5.0 × 10^(-324) a ±1.7 × 10^(308).

// string: Representa sequências de caracteres. Sem limite prático, depende da memória disponível.

// bool: Representa valores booleanos. Apenas dois valores possíveis, true ou false.

// char: Representa um único caractere Unicode. Extensão: De 0 a 65535.

// float: Representa números de ponto flutuante com menor precisão que o double. Extensão: ±1.5 x 10^(-45) a ±3.4 x 10^(38).

// long: Representa números inteiros longos. Extensão: -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807.