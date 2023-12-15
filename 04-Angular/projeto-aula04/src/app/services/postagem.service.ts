import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Postagem } from '../../models/Postagem';

@Injectable({
  providedIn: 'root'
})
export class PostagemService {

  constructor(private http: HttpClient) { }

  // url
  private urlPostagem: string = 'https://jsonplaceholder.typicode.com/posts'

  //metodo para retornar todas as postagens
  listarPostagens():Observable<Postagem[]>{
    return this.http.get<Postagem[]>(this.urlPostagem);
  }

  // observable: executa requisicoes em periodos de tempo
  // subscriber: recebe o retorno das requisicoes
}
