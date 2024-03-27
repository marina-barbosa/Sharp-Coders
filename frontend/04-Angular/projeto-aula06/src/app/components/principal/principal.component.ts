import { Component } from '@angular/core';
import { Aluno } from '../../models/Aluno';
import { FormularioComponent } from '../formulario/formulario.component';
import { TabelaComponent } from '../tabela/tabela.component';

@Component({
  selector: 'app-principal',
  standalone: true,
  imports: [FormularioComponent, TabelaComponent],
  templateUrl: './principal.component.html',
  styleUrl: './principal.component.css'
})
export class PrincipalComponent {

  // vetor de alunos
  vetor: Aluno[] = [
    { nome: 'Alice', nota1: 10, nota2: 9 },
    { nome: 'Ricardo', nota1: 10, nota2: 8 },
    { nome: 'Luciana', nota1: 7, nota2: 10 },
  ];

  //funcao de cadastro
  cadastrarAluno(obj:Aluno):void{
    this.vetor.push(obj);
  }
}
