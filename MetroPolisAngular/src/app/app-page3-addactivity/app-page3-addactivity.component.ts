import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl } from '@angular/forms';
import {HttpClient,HttpHeaders} from '@angular/common/http';



@Component({
  selector: 'app-app-page3-addactivity',
  templateUrl: './app-page3-addactivity.component.html',
  styleUrls: ['./app-page3-addactivity.component.css']
})

export class AppPage3AddactivityComponent implements OnInit {
  myform:FormGroup;
  sucess=false;
  fail=false;
  constructor(private httpService: HttpClient) { }
 
 
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
 
 
 onSubmit(addActivity) {
   if (this.myform.valid) {
     console.log(addActivity);
     this.fail=false; 
     this.sucess=false;
     var date = new Date(addActivity["date"]);
     var t=localStorage.getItem('token');
     console.log(t);
     var headers_object = new HttpHeaders().set("Authorization", "Bearer " + t);
     this.httpService.post("https://localhost:44304/api/[controller]/[id]",
      {
        
        
        "name": addActivity["name"],
        "streetName": addActivity["streetName"],
        "isStreetClosed":(addActivity["isStreetClosed"]=="true")?true:false,
        "type": addActivity["type"],
        "description": addActivity["description"],
        "date":date
      },{headers:headers_object}
      ).subscribe(
        data => {  
          console.log(data);
          if(data==true){
            this.sucess=true;
          }else if(data==false){
            this.sucess=false;
            this.fail=true;}
         }  
      );


     this.myform.reset();
   }
  }
  closealert(){
    this.sucess=false;
    this.fail=false;
  }
 }

  