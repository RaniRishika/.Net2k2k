import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from "@angular/forms";
import { User } from '../user';
import { JsonPipe } from '@angular/common';
@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
loginForm:FormGroup;
submitted=false;
item:User;
  constructor(private frombuilder:FormBuilder) {
    this.item=new User();
   }

  ngOnInit() {
    this.loginForm=this.frombuilder.group({
      uname:['',Validators.required],
      pwd:['',Validators.required]
    });
  }
  onSubmit()
  {
    this.submitted=true;
    if(this.loginForm.invalid)
    {
     return;
    }
    else
    {
      alert("Form is Validated");
      console.log(this.loginForm.value) //retrun java script object
      console.log(JSON.stringify(this.loginForm.value)) //return json object
      console.log(this.loginForm.value["uname"])
      console.log(this.loginForm.value["pwd"])
      //assign values to model
      this.item.uname=this.loginForm.value["uname"]
      this.item.pwd=this.loginForm.value["pwd"]
      console.log(this.item)
      
    }
    

  }
  // convenience getter for easy access to form fields
  get f() { return this.loginForm.controls; }
  onReset()
  {
    
    this.submitted=false;
    this.loginForm.reset();
  }

}
