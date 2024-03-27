import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { Comp01Component } from './comp-01/comp-01.component';
import { Comp02Component } from './comp-02/comp-02.component';
import { Comp03Component } from './comp-03/comp-03.component';
import { Comp04Component } from './comp-04/comp-04.component';
import { Comp05Component } from './comp-05/comp-05.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, Comp01Component,Comp02Component,Comp03Component,Comp04Component, Comp05Component],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'projeto-aula01';
}
