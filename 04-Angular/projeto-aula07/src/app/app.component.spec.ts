//importacoes
import { TestBed } from '@angular/core/testing'
import { AppComponent } from './app.component';
import { Pessoa } from './Pessoa';
//descricao do teste unitario
describe('AppComponent', () => {

  //inicializacao
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [AppComponent]
    }).compileComponents();
  });

  // validar a variavel texto
  it('Validar variavel de texto', () => {

    // fixture
    const fixture = TestBed.createComponent(AppComponent);

    // obter as variaves e funcoes docomponente
    const component = fixture.componentInstance;

    // validacao
    expect(component.texto).toEqual('Aprendendo a trabalhar com o Jasmine e o Karma');
  });


  // validar a funcao soma
  it('Validar a função soma', () => {

    // fixture
    const fixture = TestBed.createComponent(AppComponent);

    // obter as variaves e funcoes docomponente
    const component = fixture.componentInstance;

    // executar funcao e obter retorno
    let retorno = component.soma(5, 6);

    //validar
    expect(typeof retorno).toBe('number');

  });


  //validar o retorno da funcao retornarPessoa
  it('Função retornar pessoa', () => {

    // fixture
    const fixture = TestBed.createComponent(AppComponent);

    // obter as variaves e funcoes docomponente
    const component = fixture.componentInstance;

    //criar um objeto do tipo Pessoa
    const obj = new Pessoa('Hortência', 31);

    //executar funcao
    const retorno = component.retornarPessoa(obj);

    //validar
    expect(retorno instanceof Pessoa).toBeTrue();

  });


});







