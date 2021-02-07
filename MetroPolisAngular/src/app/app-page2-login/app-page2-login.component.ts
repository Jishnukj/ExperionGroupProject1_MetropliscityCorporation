import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl } from '@angular/forms';
import {HttpClientModule,HttpClient} from '@angular/common/http';
@Component({
  selector: 'app-app-page2-login',
  templateUrl: './app-page2-login.component.html',
  styleUrls: ['./app-page2-login.component.css']
})
export class AppPage2LoginComponent implements OnInit 
{
  myform:FormGroup;
  
  
  
  constructor(private httpService: HttpClient) { }
  ngOnInit()
   {
    this.myform = new FormGroup({
      username: new FormControl(''),
      password: new FormControl('')});
   
  }

  pass="";
  user="";
  i=0;
  flag=0;
   
    onSubmit(my)
    {
      if (this.myform.valid) 
      {
        console.log(my);
        this.user=my["username"];
        this.pass=my["password"];
        
        this.myform.reset();
      }
      this.flag=0;
    this.httpService.get('https://localhost:44304/api/User/api/User').subscribe(  
     data => {  
       
       console.log(data);
       console.log(data[1]["userId"]);
       for(this.i=0;data[this.i]!=null; this.i+=1)
        {
         if(data[this.i]["userName"]==this.user){
          if(data[this.i]["password"]==this.pass){
           console.log("sucess");
           this.flag=1
           // add routing here
          } 
         }
        }
        if(this.flag!=1){
          console.log("fail");
        } 
     }  
   );  
   
  

}
}