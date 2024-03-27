import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-comp-02',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './comp-02.component.html',
  styleUrl: './comp-02.component.css'
})
export class Comp02Component {
  //exibir texto
 exibirTexto: boolean = true;
 // função pra trocar true e false
 visibilidadeTexto():void{
  this.exibirTexto = !this.exibirTexto;
 }
 // vetor
 nomes: string[] = ['Brenda','Dominic','Mew','Hortência'];
 // switch case
 linguagem: string = '';


}
