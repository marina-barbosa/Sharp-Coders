import { Component, Input } from '@angular/core';
import { Aluno } from '../../models/Aluno';
import { CommonModule } from '@angular/common';
import { MediaPipe } from '../../pipes/media.pipe';

@Component({
  selector: 'app-tabela',
  standalone: true,
  imports: [CommonModule, MediaPipe],
  templateUrl: './tabela.component.html',
  styleUrl: './tabela.component.css'
})
export class TabelaComponent {
  //obtendo o vetor
  @Input() dadosVetor: Aluno[] = [];
}
