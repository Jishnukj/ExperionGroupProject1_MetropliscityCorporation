import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl } from '@angular/forms';
import {HttpClientModule,HttpClient} from '@angular/common/http';
import { AppPage3Component } from '../app-page3/app-page3.component';
import { Router} from '@angular/router';
@Component({
  selector: 'app-app-page2-login',
  templateUrl: './app-page2-login.component.html',
  styleUrls: ['./app-page2-login.component.css']
})
export class AppPage2LoginComponent implements OnInit 
{
  myform:FormGroup;
  
  
  
  constructor(private httpService: HttpClient, private router:Router ) { }
  ngOnInit()
   {
    this.myform = new FormGroup({
      username: new FormControl(''),
      password: new FormControl('')});
   
  }
  onSubmit(my){
    if (this.myform.valid) 
      {
        this.myform.reset();
      }
      this.httpService.post('https://localhost:44304/api/User/api/[controller]',
        {
  
          "userName": my["username"],
          "password": my["password"]
        }
      ).subscribe(
        (res:any)=>{
          localStorage.setItem('token',res.token);
          this.router.navigate(['AppPage3Component']);
        },
        err=>{
            alert("Incorrect username or password");
        }
      )
  }
 
 
}