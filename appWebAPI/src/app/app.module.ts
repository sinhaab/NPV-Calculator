import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import AppService from './app.service';
import { ReactiveFormsModule } from "@angular/forms";  
import { HttpClientModule } from '@angular/common/http';



@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
      AppRoutingModule,
     ReactiveFormsModule,
      HttpClientModule
     
  ],
  providers: [AppService],
  bootstrap: [AppComponent]
})
export class AppModule { }
