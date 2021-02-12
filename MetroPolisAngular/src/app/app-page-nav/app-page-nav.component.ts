import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-app-page-nav',
  templateUrl: './app-page-nav.component.html',
  styleUrls: ['./app-page-nav.component.css']
})
export class AppPageNavComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  onLogout(){
    localStorage.removeItem('token');
  }
}
