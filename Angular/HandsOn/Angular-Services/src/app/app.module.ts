import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule} from "@angular/common/http";

import {ReactiveFormsModule} from "@angular/forms";
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ViewitemComponent } from './viewitem/viewitem.component';
import { CalculateService } from './services/calculate.service';
import { TestComponent } from './test/test.component';
import { DemoComponent } from './demo/demo.component';
import { ItemService } from './services/item.service';
import { LoginComponent } from './login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    ViewitemComponent,
    TestComponent,
    DemoComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [CalculateService,ItemService],
  bootstrap: [LoginComponent]
})
export class AppModule { }
