import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/Models/student';

@Component({
  selector: 'app-demo22',
  templateUrl: './demo22.component.html',
  styleUrls: ['./demo22.component.css']
})
export class Demo22Component implements OnInit {
list:Student[]=[];
sid:number;
sname:string;
age:number;
std:string;
item:Student;
stds:string[]=["I","II","III","IV"];
val:boolean=true;
  constructor() { 
    this.list=[
      {sid:1,sname:'Rohan',std:'II',age:12},
      {sid:2,sname:'Karan',std:'I',age:10},
      {sid:3,sname:'Jeson',std:'II',age:12},
      {sid:4,sname:'Koman',std:'I',age:10},
      {sid:5,sname:'Monica',std:'II',age:12},
      {sid:6,sname:'Rajan',std:'I',age:10},
    ]
  }

  ngOnInit() {
  }
  public Add()
  {
    this.item=new Student();
    this.item.sid=this.sid;
    this.item.sname=this.sname;
    this.item.age=this.age;
    this.item.std=this.std;
    this.list.push(this.item); //add item to array
    console.log(this.list)
  }
  public SetVal()
  {
    this.val=!this.val;
  }

}
