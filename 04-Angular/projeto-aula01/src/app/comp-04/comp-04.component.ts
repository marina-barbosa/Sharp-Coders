import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-comp-04',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './comp-04.component.html',
  styleUrl: './comp-04.component.css'
})
export class Comp04Component {
  // variavel para armazenar um texto
  texto: string = '';

  // variaveis para armazenar os inputs do formulario
  email: String = ''
  senha: String = ''
}
