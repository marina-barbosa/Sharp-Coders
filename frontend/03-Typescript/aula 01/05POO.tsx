// classe
class Produto {
    // atributo
    private nome: string;
    private valor: number;

    // construtor
    public constructor(nome: string, valor: number) {
        this.nome = nome;
        this.valor = valor;
        this.mensagem();
    }

    private mensagem() {
        console.log(`O produto: ${this.nome} custa R$ ${this.valor}`);
    }
}

//instanciando objeto da classe produto
const prod = new Produto('Teclado', 180.00);
