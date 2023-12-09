import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {


  // contrutor
  constructor(private rota:Router){}

  //formulario
  formulario = new FormGroup({
    email: new FormControl('', [Validators.required, Validators.email]),
    senha: new FormControl('', Validators.required)
  })

  // funcao para autenticar
  autenticar(): void{
    if(
      this.formulario.value.email === 'flores@gmail'
      &&
      this.formulario.value.senha === '1234'
      ){
        //adicionar o e-mailno localStorage
        localStorage.setItem('email', this.formulario.value.email);

        // redirecionamento
        this.rota.navigateByUrl(`/admin`)
      } else {
        alert(`Email ou senha incorretos`)
      }
  }


}
