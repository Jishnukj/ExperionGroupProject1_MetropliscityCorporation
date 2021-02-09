import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';
import { HttpClient } from '@angular/common/http';
@Component({
  selector: 'app-showact',
  templateUrl: './showact.component.html',
  styleUrls: ['./showact.component.css']
})
export class ShowactComponent implements OnInit {

  constructor(private http:HttpClient) { }

  ActivityList:any=[]

  ngOnInit(): void {
    this.refreshActList();
  }

  refreshActList(){
    this.http.get("https://localhost:44304/api/sorted").subscribe(data=>{
      this.ActivityList=data;
    });

  }
}
