import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { EnderecoService } from '../../services/endereco.service';

@Component({
  selector: 'app-endereco',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './endereco.component.html',
  styleUrl: './endereco.component.css'
})
export class EnderecoComponent {
  //variael cep
  cep: string = '';

  // construtor
  constructor(private services:EnderecoService){}

  //funcao para obter oendereco
  obterEndereco(): void {
    this.services.retornarEndereco(this.cep)
    .subscribe(returnData => {
      console.log(returnData);
    })
  }
}
