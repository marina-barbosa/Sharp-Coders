import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';



@Component({
  selector: 'app-contact',
  standalone: true,
  imports: [MatCardModule, MatFormFieldModule, MatButtonModule, MatInputModule, FormsModule],
  templateUrl: './contact.component.html',
  styleUrl: './contact.component.css'
})
export class ContactComponent {

  nome:string;
  email:string;
  mensagem:string;

  constructor(){
    this.nome='';
    this.email='';
    this.mensagem='';
  }

enviarFomulario() {
  console.log(this.nome);
  console.log(this.email);
  console.log(this.mensagem);
  
}

}
