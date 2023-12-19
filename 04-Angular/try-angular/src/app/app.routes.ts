import { Routes } from '@angular/router';
import { ContactComponent } from './pages/contact/contact.component';
import { HomeComponent } from './pages/home/home.component';
import { LoginComponent } from './pages/login/login.component';

export const routes: Routes = [
    {path:'home', component:HomeComponent},
    {path:'contact', component:ContactComponent},
    {path:'login', component:LoginComponent},
    {path:'', redirectTo:'/home', pathMatch:'full'},
    {path:'**', component:HomeComponent},
];
