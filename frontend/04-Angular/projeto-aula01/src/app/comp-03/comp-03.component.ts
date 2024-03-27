import { Component } from '@angular/core';

@Component({
  selector: 'app-comp-03',
  standalone: true,
  imports: [],
  templateUrl: './comp-03.component.html',
  styleUrl: './comp-03.component.css'
})
export class Comp03Component {

  // variavel de média
  media: number = 8;

  linguagem: string = 'CSS';

  nomes: string[] = ['Marina','Brenda', 'Dominic'];
}
