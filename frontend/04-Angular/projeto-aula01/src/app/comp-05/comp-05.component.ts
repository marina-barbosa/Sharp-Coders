import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-comp-05',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './comp-05.component.html',
  styleUrl: './comp-05.component.css'
})
export class Comp05Component {


  // objeto de formulario
  formulario = new FormGroup({
    email: new FormControl(''),
    senha: new FormControl('')
  });

  enviar(): void {
    alert('Method not implemented.');
  }



}
