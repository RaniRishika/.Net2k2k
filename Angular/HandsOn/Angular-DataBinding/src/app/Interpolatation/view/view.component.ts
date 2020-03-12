import { Component, OnInit } from '@angular/core';
import { Student } from 'src/app/Models/student';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {

  obj:Student;
  constructor() {
    this.obj={Sid:1,Sname:'Joy',DOB:new Date(2009,12,23),Age:12,Std:"II"};
   }

  ngOnInit() {
  }

}
