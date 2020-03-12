import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
 items: any[] = [
   {name: 'One', val: 1}, 
   {name: 'Two', val: 2}, 
   {name: 'Three', val: 3}
  ];  
  selectedValue: string= 'One';  
  constructor() { }

  ngOnInit() {
  }

}
