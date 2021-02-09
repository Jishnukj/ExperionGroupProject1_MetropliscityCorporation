import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service'
@Component({
  selector: 'app-showact',
  templateUrl: './showact.component.html',
  styleUrls: ['./showact.component.css']
})
export class ShowactComponent implements OnInit {

  constructor(private service: SharedService) { }

  ActivityList:any=[]

  ngOnInit(): void {
    this.refreshActList();
  }

  refreshActList(){
    this.service.getActList().subscribe(data=>{
      this.ActivityList=data;
    });

  }
}
