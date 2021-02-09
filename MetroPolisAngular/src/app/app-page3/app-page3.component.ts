import { Component, OnInit } from '@angular/core';
import {ItemService} from '../Services/item.service';

@Component({
  selector: 'app-app-page3',
  templateUrl: './app-page3.component.html',
  styleUrls: ['./app-page3.component.css']
})
export class AppPage3Component implements OnInit {

  constructor(private itemservice:ItemService) { }
  services;
  login;
  ngOnInit(): void {
    this.login=this.itemservice.login;
    this.services=this.itemservice.services;
    console.log("page3");
  }
  loginHide(){
    this.itemservice.loginHide
  }
}
