import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { MatListModule } from '@angular/material/list';
import { MatSidenavModule } from '@angular/material/sidenav';
import { RouterLink, RouterOutlet } from '@angular/router';
import { FooterComponent } from "./components/footer/footer.component";
import { NavbarComponent } from "./components/navbar/navbar.component";
import { UserComponent } from "./pages/user/user.component";
import { SharedService } from './shared/shared.service';

@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [CommonModule, RouterOutlet, RouterLink, NavbarComponent, FooterComponent, MatSidenavModule, MatListModule, UserComponent]
})
export class AppComponent implements OnInit{
  
    title='try-angular';
    showFiller = false;
    isAuth:boolean=false;

  constructor(private shared:SharedService){}

  ngOnInit(): void {
    this.shared.getUsername().subscribe((retorno:string)=>{
      if(retorno){
        this.isAuth=true;
      } else {
        this.isAuth=false;
      }
    });
  }


}
