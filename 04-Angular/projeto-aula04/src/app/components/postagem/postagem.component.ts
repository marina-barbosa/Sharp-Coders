import { Component } from '@angular/core';
import { PostagemService } from '../../services/postagem.service';
import { Postagem } from '../../../models/Postagem';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-postagem',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './postagem.component.html',
  styleUrl: './postagem.component.css'
})
export class PostagemComponent {
  // construtor
  constructor(private servicesPostagem: PostagemService) { }

  // vetor de postagens
  postagens: Postagem[] = [];

  // ao iniciar (qdo o component é criado)
  ngOnInit(){
    this.listarPostagens();
  }

  // funcao para listar as postagens
  listarPostagens(): void {
    this.servicesPostagem.listarPostagens()
    .subscribe(dataReturn => {
      this.postagens = dataReturn;
     })
  }
}
