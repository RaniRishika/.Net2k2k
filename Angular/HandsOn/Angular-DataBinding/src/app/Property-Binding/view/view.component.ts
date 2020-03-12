import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/Models/student';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {
item:Student
url:string='http://www.google.co.in'
  constructor() { 
    this.item=new Student();
    this.item.Sid=1;
    this.item.Sname="Rohan";
    this.item.Std="II";
    this.item.Age=13;
    this.item.DOB=new Date(2008,12,23);
  }

  ngOnInit() {
  }

}
