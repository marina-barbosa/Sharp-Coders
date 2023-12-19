import { Component, Input } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { MatSlideToggleModule } from '@angular/material/slide-toggle';
import { MatToolbarModule } from '@angular/material/toolbar';
import { RouterModule } from '@angular/router';
import { SharedService } from '../../shared/shared.service';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [MatToolbarModule, MatButtonModule, MatIconModule, MatSlideToggleModule, RouterModule],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {
  @Input() Drawer: any;

  usuarioLogado:string='';

  constructor(private shared:SharedService){
    shared.getUsername().subscribe((retorno:string)=>{
      this.usuarioLogado=retorno;
    })
  }

  public showMenu(){
    this.Drawer.toggle();
  }

}
