import { Component, OnInit } from '@angular/core';
import { FormBuilder,FormGroup } from "@angular/forms";
import { Item } from '../item';
import { ItemService } from '../services/item.service';
@Component({
  selector: 'app-viewitem',
  templateUrl: './viewitem.component.html',
  styleUrls: ['./viewitem.component.css']
})
export class ViewitemComponent implements OnInit {
  itemForm:FormGroup;
  submitted=false;
list:Item[];
item:Item;
  constructor(private builder:FormBuilder,private service:ItemService) {
      this.service.GetAll().subscribe(res=>{
        this.list=res;
        console.log(this.list);
      },err=>{
        console.log(err)
      })
  }

  ngOnInit() {
    this.itemForm=this.builder.group({
      id:[''],
      name:[''],
      price:[''],
      stock:['']
    });
  }
  get f() { return this.itemForm.controls; }

  onSubmit() {
      this.submitted = true;
      this.Add();
  }

  onReset() {
      this.submitted = false;
      this.itemForm.reset();
  }
  Search()
  {
    let id=this.itemForm.value["id"];
    this.service.GetById(id).subscribe(res=>{
      this.item=res;
      console.log(this.item);
          this.itemForm.setValue({
    id:this.item.itemid,
    name:this.item.name,
    price:this.item.price,
    stock:this.item.stock,
          })

    })
  }
  Add()
  {
    this.item=new Item();
    this.item.itemid=this.itemForm.value["id"];
    this.item.name=this.itemForm.value["name"];
    this.item.price=Number(this.itemForm.value["price"]);
    this.item.stock=Number(this.itemForm.value["stock"]);
    console.log(this.item);
    this.service.AddItem(this.item).subscribe(res=>{
      console.log('Record Added')
    })
  }
    Update()
  {
    this.item=new Item();
    this.item.itemid=this.itemForm.value["id"];
    this.item.name=this.itemForm.value["name"];
    this.item.price=Number(this.itemForm.value["price"]);
    this.item.stock=Number(this.itemForm.value["stock"]);
    console.log(this.item);
    this.service.UpdateItem(this.item).subscribe(res=>{
      console.log('Record Updated')
    })

  }
Delete()
{
  let id=this.itemForm.value["id"];
  this.service.DeleteItem(id).subscribe(res=>{
    console.log('Record deleted');
  },err=>{
    console.log(err);
  })
}

}
