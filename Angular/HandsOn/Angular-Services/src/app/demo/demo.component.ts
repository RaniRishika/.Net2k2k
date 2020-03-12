import { Component, OnInit } from '@angular/core';
import { ItemService } from '../services/item.service';
import { Item } from '../item';

@Component({
  selector: 'app-demo',
  templateUrl: './demo.component.html',
  styleUrls: ['./demo.component.css']
})
export class DemoComponent implements OnInit {
list:Item[];
  constructor(private item:ItemService) { }

  ngOnInit() {
    this.item.GetAll().subscribe(res=>
      {
this.list=res;
console.log(this.list);
      })
  }

}
