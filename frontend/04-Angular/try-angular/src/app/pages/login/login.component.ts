import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { Router } from '@angular/router';
import { SharedService } from '../../shared/shared.service';


@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule, MatCardModule, MatFormFieldModule, MatInputModule, MatButtonModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

 username:string='';
 senha:string='';
 mensagem:string='';

 constructor(private rota:Router, private shared:SharedService){ }

 login():void {
  if(this.username=='admin' && this.senha == 'admin'){ 
    this.shared.setUsername(this.username);   
    this.rota.navigateByUrl(`/home`)
  } else {
    this.mensagem='incorreto';
  }
 }
 
}
