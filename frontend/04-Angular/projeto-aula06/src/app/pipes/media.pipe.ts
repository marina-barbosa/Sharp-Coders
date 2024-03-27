import { Pipe, PipeTransform } from '@angular/core';
import { Aluno } from '../models/Aluno';

@Pipe({
  name: 'media',
  standalone: true
})
export class MediaPipe implements PipeTransform {

  transform(obj: Aluno): number {
    // extrair notas
    let nota1: number = obj.nota1 || 0;
    let nota2: number = obj.nota2 || 0;

    //realiza calculo de media
    let media: number = (nota1 + nota2) / 2;

    //retorna
    return media;
  }

}
