// - classes, 
// - objetos,
// - herança,
// - polimorfismo,
// - encapsulamento
// - abstração




// Classes:
// Uma classe é uma estrutura de código que define um tipo de objeto. Ela é a base para criar objetos. Em C#, a estrutura básica de uma classe é a seguinte:

// Declaração de uma classe simples
public class Pessoa
{
    // Atributos
    public string Nome;
    public int Idade;

    // Método
    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}





// Objetos:
// Um objeto é uma instância de uma classe. Significa que é uma cópia da classe, com seus próprios valores e estado. Aqui está como você pode criar um objeto da classe acima:

Pessoa programador = new Pessoa();
programador.Nome = "João";
programador.Idade = 30;
programador.Apresentar(); // Saída: Olá, meu nome é João e tenho 30 anos.






// Herança:
// Herança é um conceito onde uma classe pode herdar características e comportamentos de outra classe. A classe que é herdada é chamada de classe base ou classe pai, e a classe que herda é chamada de classe derivada ou classe filha.

// Classe base
public class Funcionario
{
    public string Nome;
    public double Salario;

    public void Trabalhar()
    {
        Console.WriteLine("Realizando tarefas gerais de um funcionário.");
    }
}

// Classe derivada
public class Programador : Funcionario
{
    public string Linguagem;

    public void Codificar()
    {
        Console.WriteLine($"Codificando em {Linguagem}.");
    }
}

Programador umProgramador = new Programador();
umProgramador.Trabalhar(); // Chama o método da classe base
umProgramador.Codificar(); // Chama o método da classe derivada




// Polimorfismo:
// Polimorfismo permite que um objeto seja tratado como se fosse de um tipo diferente. Existem dois tipos principais de polimorfismo: polimorfismo de tempo de compilação (sobrecarga de método) e polimorfismo de tempo de execução (sobrescrita de método).

// 1. Polimorfismo de Tempo de Compilação (Estático):

// a. Sobrecarga de Método:
// A sobrecarga de método é um exemplo de polimorfismo de tempo de compilação. Nela, você pode ter vários métodos com o mesmo nome em uma classe, mas com parâmetros diferentes. O compilador determina qual método chamar com base nos tipos de argumentos.

class Calculadora
{
    public int Somar(int a, int b)
    {
        return a + b;
    }

    public double Somar(double a, double b)
    {
        return a + b;
    }
}



// b. Operador de Sobrecarga:
// A sobrecarga de operador também é uma forma de polimorfismo de tempo de compilação, onde você pode definir o comportamento de operadores para tipos personalizados.

class Ponto
{
    public int X { get; set; }
    public int Y { get; set; }

    public static Ponto operator +(Ponto ponto1, Ponto ponto2)
    {
        return new Ponto { X = ponto1.X + ponto2.X, Y = ponto1.Y + ponto2.Y };
    }
}


// 2.Polimorfismo de Tempo de Execução (Dinâmico):

// a.Herança e Substituição de Método:
// A herança permite que uma classe filha herde métodos de uma classe pai. O polimorfismo de tempo de execução ocorre quando você substitui um método na classe filha.

// Neste exemplo, mesmo que a referência seja do tipo Animal, o método EmitirSom da classe Cachorro é chamado, mostrando polimorfismo de tempo de execução.
class Animal
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("Som genérico de animal.");
    }
}

class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("Latindo...");
    }
}

class Program
{
    static void Main()
    {
        Animal animal = new Cachorro();
        animal.EmitirSom(); // Chama o método da classe Cachorro
    }
}





// Encapsulamento:
// Encapsulamento é o conceito de esconder os detalhes de implementação interna de uma classe e fornecer uma interface pública para interagir com a classe. Isso é alcançado usando modificadores de acesso como public, private, protected, etc.

public class Pessoa
{
    // Atributos privados
    private string nome;
    private int idade;

    // Propriedades públicas
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Idade
    {
        get { return idade; }
        set { idade = value; }
    }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
    }
}






// Abstração:
// Abstração é o processo de simplificar complexidades, fornecendo uma interface clara e fácil de usar. Em C#, a abstração é frequentemente alcançada por meio de classes abstratas e interfaces.

// Classe abstrata
public interface IProgramador
{
    void Codificar();
}

public class Programador : Funcionario, IProgramador
{
    public string Linguagem;

    public void Codificar()
    {
        Console.WriteLine($"Codificando em {Linguagem}.");
    }
}

// Classe Abstrata:
// Uma classe abstrata não pode ser instanciada diretamente. Ela serve como uma base para outras classes e pode conter métodos abstratos (métodos sem implementação).

public abstract class Veiculo
{
    public abstract void Acelerar();
}

public class Carro : Veiculo
{
    public override void Acelerar()
    {
        Console.WriteLine("Carro acelerando...");
    }
}

// Interface:
// Uma interface é um contrato que define um conjunto de métodos que uma classe deve implementar.

public interface IImprimivel
{
    void Imprimir();
}

public class Documento : IImprimivel
{
    public void Imprimir()
    {
        Console.WriteLine("Imprimindo o documento...");
    }
}

// Uso de Abstração em Polimorfismo:
// Você pode usar abstração para criar uma coleção de objetos que compartilham um contrato comum.
public class Impressora
{
    public void ImprimirDocumento(IImprimivel documento)
    {
        documento.Imprimir();
    }
}

// Uso de abstração em polimorfismo
Impressora minhaImpressora = new Impressora();
minhaImpressora.ImprimirDocumento(new Documento());