import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl } from '@angular/forms';



@Component({
  selector: 'app-app-page3-addactivity',
  templateUrl: './app-page3-addactivity.component.html',
  styleUrls: ['./app-page3-addactivity.component.css']
})

export class AppPage3AddactivityComponent implements OnInit {
  myform:FormGroup;
 
 
   ngOnInit() {
     this.myform = new FormGroup({
       name : new FormControl(''),
       type : new FormControl(''),
       description : new FormControl(''),
       streetName : new FormControl(''),
       date : new FormControl(''),
       isStreetClosed : new FormControl(''),
   });
 }
 
 
 onSubmit(my) {
   if (this.myform.valid) {
     console.log(my);
     this.myform.reset();
   }
 }
 }

  