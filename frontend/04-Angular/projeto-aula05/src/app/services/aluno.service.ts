import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Aluno } from '../models/Aluno';

@Injectable({
  providedIn: 'root'
})
export class AlunoService {

  //url
  private url: string ='http://localhost:3000/alunos'

  constructor(private http:HttpClient) { }

  //metodo para selecionar alunos
  selecionar():Observable<Aluno[]>{
    return this.http.get<Aluno[]>(this.url);
  }

  //metodo para cadastrar alunos
  cadastrar(obj:Aluno):Observable<Aluno>{
    return this.http.post<Aluno>(this.url, obj);
  }


  //metodo para remover alunos
  remover(id:number):Observable<any>{
    return this.http.delete<any>(`${this.url}/${id}`);
  }

}
