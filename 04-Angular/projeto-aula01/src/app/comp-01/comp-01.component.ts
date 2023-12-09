import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-comp-01',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './comp-01.component.html',
  styleUrl: './comp-01.component.css'
})
export class Comp01Component {
  //variavel
  texto: string = 'Hello World!';

  //objeto
  pessoa: any = {
    nome: 'Marina',
    idade: 31
  }

  gato: any = {
    nome: 'Marie',
    idade: 13
  }

  //vetor

}
