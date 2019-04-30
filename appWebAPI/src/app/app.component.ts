import { Component, OnInit } from '@angular/core';
import {HttpClient} from "@angular/common/http";
import { FormBuilder, FormGroup, Validators } from "@angular/forms"; 
import { NgForm } from '@angular/forms';
import { Observable } from 'rxjs/Observable';
import AppService from './app.service';
import NPVEntity from './npv.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
    npvrate : number;
    npv: NPVEntity = new NPVEntity();
    constructor(private http: HttpClient,private appService: AppService,private formBuilder: FormBuilder) { }
    btnvisibility: boolean = true; 
    visibility: boolean = false;
    addForm: FormGroup; 
    ngOnInit() {
  
      this.addForm = this.formBuilder.group({  
      
      lowerBoundRate: ['', Validators.required],  
      upperBoundRate: ['', Validators.required],
      discountRate: ['', Validators.required]
    });  
     
    }
    onSubmit() {  
    
    this.appService.save(this.addForm.value)  
      .subscribe(data => {  
          this.npvrate= data ;
          this.visibility = true; 
      },  
      error => {  
        alert(error);  
      });  
  }  

}
