

// Métodos com Modificadores de Acesso:
// Em C#, os modificadores de acesso são utilizados para controlar a visibilidade e acessibilidade dos membros de uma classe. Existem quatro modificadores de acesso principais: public, private, protected, e internal.


// Public:
// Um método marcado como public é acessível de qualquer lugar, seja dentro da classe, de classes derivadas ou de qualquer parte do código que faça referência à classe.
public class MinhaClasse
{
    public void MetodoPublico()
    {
        // Código do método aqui
    }
}



// Private:
// Um método marcado como private só pode ser acessado dentro da própria classe. É útil quando você deseja encapsular certas funcionalidades e impedir o acesso direto de outras partes do código.
public class MinhaClasse
{
    private void MetodoPrivado()
    {
        // Código do método aqui
    }
}



// Protected:
// Um método marcado como protected é acessível dentro da própria classe e por classes derivadas (herdeiras).
public class MinhaClasse
{
    protected void MetodoProtegido()
    {
        // Código do método aqui
    }
}



// Internal:
// Um método marcado como internal é acessível apenas dentro do mesmo assembly. Um assembly é basicamente um arquivo executável ou uma DLL.
internal class MinhaClasse
{
    internal void MetodoInterno()
    {
        // Código do método aqui
    }
}



// Métodos Estáticos vs. Métodos de Instância:



// Métodos Estáticos:
// Métodos estáticos pertencem à classe, não a instâncias específicas da classe. Eles são chamados na classe em si, não em uma instância da classe.
public class MinhaClasse
{
    public static void MetodoEstatico()
    {
        // Código do método aqui
    }
}
// Para chamar um método estático, você usa o nome da classe, seguido por um ponto e o nome do método:
MinhaClasse.MetodoEstatico();



// Métodos de Instância:
// Métodos de instância pertencem a instâncias específicas da classe. Eles são chamados em uma instância da classe usando o operador ponto.
public class MinhaClasse
{
    public void MetodoDeInstancia()
    {
        // Código do método aqui
    }
}
// Para chamar um método de instância, você precisa criar uma instância da classe e, em seguida, chamar o método nessa instância:
MinhaClasse minhaInstancia = new MinhaClasse();
minhaInstancia.MetodoDeInstancia();




// Esses conceitos são fundamentais para entender a encapsulação, a herança e a criação de código modular em C#. A escolha entre métodos estáticos e de instância depende da funcionalidade que você está implementando e da forma como você deseja que ela seja acessada.