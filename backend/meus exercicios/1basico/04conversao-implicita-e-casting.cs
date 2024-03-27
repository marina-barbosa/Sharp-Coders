

// Conversão Implícita:


// Conversões Numéricas:
// Entre tipos numéricos onde não há risco de perda de dados.
int idade = 10;
double altura = idade; // Conversão implícita de int para double



// Conversão de Char para Int:
// Um 'char' pode ser implicitamente convertido para seu valor ASCII.
char caractere = 'A';
int valorASCII = caractere; // Converte 'A' para 65



// Conversão de Subtipos para Supertipos:
// Conversão de uma classe derivada para sua classe base.
class Pessoa { }
class Cliente : Pessoa { }
Cliente cliente = new Cliente();
Pessoa pessoa = cliente; // Conversão implícita de Cliente para Pessoa



// Conversão Explícita (Casting):



// Casting Numérico:
// Pode haver perda de dados ao converter tipos numéricos.
double alturaExplicita = 10.5;
int alturaInteira = (int)alturaExplicita; // Casting de double para int (perda de .5)



// Casting entre Tipos de Referência:
// Entre classes ou interfaces relacionadas.
object objeto = "Olá";
string saudacao = (string)objeto; // Casting de object para string



// Casting de Enum para Int:
// Enums podem ser convertidos para int explicitamente.
enum DiasDaSemana { Domingo, Segunda, Terca }
int diaUtil = (int)DiasDaSemana.Segunda; // Casting de enum para int



// Casting de Int para Char:
// Convertendo um valor inteiro para um caractere.
int valorInteiroParaCaractere = 65;
char caractereExplicito = (char)valorInteiroParaCaractere; // Casting de int para char ('A')



// Casting de Interface:
// Entre interfaces.
interface IPessoa { }
class ClienteEspecial : IPessoa { }
ClienteEspecial clienteEspecial = new ClienteEspecial();
IPessoa pessoaEspecial = (IPessoa)clienteEspecial; // Casting de ClienteEspecial para IPessoa
