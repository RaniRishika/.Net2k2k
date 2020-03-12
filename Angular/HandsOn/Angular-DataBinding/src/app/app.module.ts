import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {  FormsModule} from "@angular/forms";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DemoComponent } from './Interpolatation/demo/demo.component';
// import { ViewComponent } from './Interpolatation/view/view.component';
import { ViewComponent } from './Property-Binding/view/view.component';
import { EventDemoComponent } from './Event-Binding/event-demo/event-demo.component';
import { Demo1Component } from './Twoway-Binding/demo1/demo1.component';
import { Demo2Component } from './Twoway-Binding/demo2/demo2.component';
@NgModule({
  declarations: [
    AppComponent,
    DemoComponent,
    ViewComponent,
    EventDemoComponent,
    Demo1Component,
    Demo2Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [Demo2Component]
})
export class AppModule { }
