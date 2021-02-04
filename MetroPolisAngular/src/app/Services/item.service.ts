import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ItemService {

  constructor() { }
  services= true;
  login=false;
  serviceHide(){
    if(this.login==false){
      this.services=!this.services;
      console.log("services");
    }
  }
  loginHide(){
    this.login=!this.login;
    console.log("login");
  }
}
