import { Component, OnInit } from '@angular/core';
import {ItemService} from './Services/item.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'MetroPolisAngular';
  services;
  login;
  constructor(private itemservice:ItemService){}
  ngOnInit(){
      this.services=this.itemservice.services;
      this.login=this.itemservice.login
  }

  serviceHide(){
    this.itemservice.serviceHide();
    this.services=this.itemservice.services;
  }
}
