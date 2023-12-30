import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'projeto-aula01';

  constructor(private http:HttpClient){

  }

  ngOnInuit(){

  }

  criarToken():Observable<any>{
    return this.http.post<any>('http://www.localhost:3333',
    {'usuario':'admin', 'senha':'admin'})
  }
}
