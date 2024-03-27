import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { SharedService } from './shared.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard {

  constructor(private shared: SharedService, private router: Router) { }

  canActivate(): Observable<boolean> | boolean{
    let logged:boolean=this.shared.isAuthenticated();

    if(!logged){
      this.router.navigate(['login']);
    }
    return logged;
  }
}

