import { Component, OnInit } from '@angular/core';
import {ItemService} from '../Services/item.service';
@Component({
  selector: 'app-app-page2-login',
  templateUrl: './app-page2-login.component.html',
  styleUrls: ['./app-page2-login.component.css']
})
export class AppPage2LoginComponent implements OnInit {

  constructor(private itemservice:ItemService) { }
  services;
  login;
  ngOnInit(): void {
    this.login=this.itemservice.login;
    this.services=this.itemservice.services;
  }
  loginHide(){
    this.itemservice.loginHide();
    this.login=this.itemservice.login;
    console.log(this.login); 
  }

}
