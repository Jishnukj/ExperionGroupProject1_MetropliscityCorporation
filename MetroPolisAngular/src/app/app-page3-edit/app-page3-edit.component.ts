import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl } from '@angular/forms';
import {HttpClientModule,HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-app-page3-edit',
  templateUrl: './app-page3-edit.component.html',
  styleUrls: ['./app-page3-edit.component.css']
})
export class AppPage3EditComponent implements OnInit {

  myform:FormGroup
  constructor(private httpService: HttpClient) { }
  sucess=false;
  fail=false;
  url="https://localhost:44304/api/[controller]/[id]?id=";
  ngOnInit() {
    this.myform = new FormGroup({
      id : new FormControl(''),
      name : new FormControl(''),
      type : new FormControl(''),
      description : new FormControl(''),
      strname : new FormControl(''),
      date : new FormControl(''),
      Isstreetclosed : new FormControl(''),
  });
}


onSubmit(addActivity) {
  if (this.myform.valid) {
    console.log(addActivity);
    this.myform.reset();
    var date = new Date(addActivity["date"]);
    this.httpService.patch(`${this.url}${addActivity["id"]}`,
    {
        
        
      "name": addActivity["name"],
      "streetName": addActivity["strname"],
      "isStreetClosed":(addActivity["Isstreetclosed"]=="true")?true:false,
      "type": addActivity["type"],
      "description": addActivity["description"],
      "date":date
    }
    ).subscribe((res:any)=>{
      this.sucess=true;
    },
    err=>{
      this.fail=true;
          }
              
          );
        }
      }
      closealert(){
        this.sucess=false;
        this.fail=false;
      }
}
