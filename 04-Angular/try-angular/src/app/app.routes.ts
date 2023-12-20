import { Routes } from '@angular/router';
import { ContactComponent } from './pages/contact/contact.component';
import { HomeComponent } from './pages/home/home.component';
import { LoginComponent } from './pages/login/login.component';
import { UserComponent } from './pages/user/user.component';
import { AuthGuard } from './shared/auth-guard.service';

export const routes: Routes = [
    {path:'home', component:HomeComponent, canActivate:[AuthGuard]},
    {path:'contact', component:ContactComponent, canActivate:[AuthGuard]},
    {path:'user', component:UserComponent, canActivate:[AuthGuard]},
    {path:'login', component:LoginComponent},
    {path:'', redirectTo:'/login', pathMatch:'full'},
    {path:'**', component:LoginComponent},
];
