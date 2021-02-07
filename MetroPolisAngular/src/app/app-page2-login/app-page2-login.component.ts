import { Component, OnInit } from '@angular/core';
import { FormGroup,FormControl } from '@angular/forms';
@Component({
  selector: 'app-app-page2-login',
  templateUrl: './app-page2-login.component.html',
  styleUrls: ['./app-page2-login.component.css']
})
export class AppPage2LoginComponent implements OnInit 
{
  myform:FormGroup;
  
  
  
  
  ngOnInit()
   {
    this.myform = new FormGroup({
      username: new FormControl(''),
      password: new FormControl('')});
   
  }
   
 onSubmit(my)
{
  if (this.myform.valid) 
  {
    console.log(my);
    this.myform.reset();
  }
}
  

}