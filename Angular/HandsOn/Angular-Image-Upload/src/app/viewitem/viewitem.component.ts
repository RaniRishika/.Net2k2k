import { Component, OnInit } from '@angular/core';
import { Item } from '../item';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-viewitem',
  templateUrl: './viewitem.component.html',
  styleUrls: ['./viewitem.component.css']
})
export class ViewitemComponent implements OnInit {
items:Item[]=[];
item:Item;
name:string;
img:string;
selectedFile : File = null;
constructor(private http: HttpClient) { }

  ngOnInit() {
  }
  Upload()
  {
    this.item=new Item();
    this.item.name=this.name;
    this.item.img=this.img;
    console.log(this.item)
    this.items.push(this.item);
    console.log(this.items);

  }
  fileEvent(event){
    this.img = event.target.files[0].name;
}


}
