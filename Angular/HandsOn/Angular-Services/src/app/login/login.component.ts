import { Component, OnInit } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { Router } from "@angular/router";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private service:AuthService,private router:Router) { }

  ngOnInit() {
  }
  Validate()
  {
    this.service.Validate('Admin','12345').subscribe(res=>{
      if(res.uname=='Admin')
      {
        localStorage.setItem('token',res.token)
      console.log(res)
      this.router.navigateByUrl('item');
      }
      else if(res.token==""||res.token==null)
      {
        console.log('Invalid Id');
      }
      else
      {
      localStorage.setItem('token',res.token)
      console.log(res)
      this.router.navigateByUrl('item');
      }
    })
  }

}
