import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatIconModule } from '@angular/material/icon';
import { MatInputModule } from '@angular/material/input';
import { MatTableModule } from '@angular/material/table';
import { UserModel } from './Models/user.model';



@Component({
  selector: 'app-user',
  standalone: true,
  imports: [MatTableModule, MatIconModule, MatButtonModule, MatCardModule, FormsModule, MatFormFieldModule, MatInputModule],
  templateUrl: './user.component.html',
  styleUrl: './user.component.css'
})
export class UserComponent implements OnInit{
  dataSource:UserModel[]=[];
  userAdd:UserModel = new UserModel;

  ngOnInit(): void {
    this.dataSource=[ 
      {
        id:0,
        name:'test0',
        email:'test0@gmail'
      },
      {
        id:1,
        name:'test1',
        email:'test1@gmail'
      }
    ]
  }

  btnSearch(user:UserModel):void{
    alert('buscando');
  }
  btnDelete(user:UserModel):void{
    let index = this.dataSource.findIndex((item)=>item == user);
    this.dataSource.splice(index,1);
    this.dataSource = Array.from(this.dataSource);
  }
  btnSave():void{
    if(this.userAdd.name){
      alert('Salvo!');
      this.dataSource.push(this.userAdd);
      this.dataSource = Array.from(this.dataSource);
    }
  }
}
