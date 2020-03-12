import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ViewitemComponent } from './viewitem/viewitem.component';


const routes: Routes = [
  {path:'item',component:ViewitemComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
