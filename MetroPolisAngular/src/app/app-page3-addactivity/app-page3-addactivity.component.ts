import { Component, OnInit } from '@angular/core';
import {FormBuilder,Validators,FormGroup,FormArray, FormControl} from '@angular/forms';
import { Router } from '@angular/router';


@Component({
  selector: 'app-app-page3-addactivity',
  templateUrl: './app-page3-addactivity.component.html',
  styleUrls: ['./app-page3-addactivity.component.css']
})

export class AppPage3AddactivityComponent implements OnInit{
  form:FormGroup;

  ngOnInit(){
    this.form=new FormGroup({
      name: new FormControl(''),
      type: new FormControl(''),
      description: new FormControl(''),
      strname: new FormControl(''),
      date: new FormControl(''),
      isstrclosed: new FormControl('')
    });
  }

  onSubmit(form){
    console.log(form);
  }


  //log(x){console.log(x);}
}

/*export class AddactivityComponent implements OnInit{
 constructor(private router:Router){ }

  ngOnInit(){
     console.log('hit');
  }  
   
  activityAdd(e){
    e.preventDefault();
    console.log(e);
    var name = e.target.elements[0].value;
    var type = e.target.elements[1].value;
    var desc = e.target.elements[2].value;
    var strname = e.target.elements[3].value;
    var date = e.target.elements[4].value;
    var isclosed = e.target.elements[0].value;

  }
  

log(x){console.log(x);}
    
  
}*/

/*export class AppPage3AddactivityComponent {

log(x){console.log(x);}
}*/

/*export class AppPage3AddactivityComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

}*/
