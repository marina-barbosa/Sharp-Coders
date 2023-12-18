import { Routes } from '@angular/router';
import { HomeComponent } from './pages/home/home.component';
import { ContactComponent } from './pages/contact/contact.component';

export const routes: Routes = [
    {path:'', redirectTo:'/home', pathMatch:'full'},
    {path:'**', component:HomeComponent},
    {path:'home', component:HomeComponent},
    {path:'contact', component:ContactComponent},
];
