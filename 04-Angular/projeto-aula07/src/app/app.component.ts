import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Pessoa } from './Pessoa';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {

  // variavel de textp
  texto: string = 'Aprendendo a trabalhar com o Jasmine e o Karma';

  //funcao para retornar a soma
  soma(n1: number, n2: number): number {
    return n1 + n2;
  }

  // funcao para retornar um onjeto do tipo pessoa
  retornarPessoa(obj:Pessoa):Pessoa{
    return obj;
  }

}
