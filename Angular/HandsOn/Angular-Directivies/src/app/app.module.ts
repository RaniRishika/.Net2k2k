import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Demo1Component } from './NG-IF/demo1/demo1.component';
import { Demo11Component } from './NG-FOR/demo11/demo11.component';
import { Demo22Component } from './NG-FOR/demo22/demo22.component';
import { DemoComponent } from './NG-SWITCH/demo/demo.component';

@NgModule({
  declarations: [
    AppComponent,
    Demo1Component,
    Demo11Component,
    Demo22Component,
    DemoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [Demo22Component]
})
export class AppModule { }
