import { Component, OnInit } from '@angular/core';
import { CalculateService } from '../services/calculate.service';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent implements OnInit {

  constructor(private service:CalculateService) { }

  ngOnInit() {
console.log('Addition:'+this.service.Add(12,34));
console.log('Multiplication:'+this.service.Mul(2,4));
console.log(this.service.Greet('Sachin'))
  }
  f()
  {
    console.log(this.service.Greet('Rahul'))
  }

}
