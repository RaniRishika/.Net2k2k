import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
uname:string
  constructor(private route:Router) {
    if(sessionStorage.getItem("un"))
    {
    //read session-storage
    this.uname=sessionStorage.getItem("un")
    console.log(this.uname)
    }
    else
    {
       this.route.navigateByUrl('login')
    }
   }

  ngOnInit() {
  }
  public LogOut()
  {
    //clear session-data
    sessionStorage.clear();
    this.route.navigate(['login']);
    //this.route.navigateByUrl('login')
  }

}
