import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-show-act',
  templateUrl: './show-act.component.html',
  styleUrls: ['./show-act.component.css']
})
export class ShowActComponent implements OnInit {
;
  constructor(private service: SharedService,private http:HttpClient) { }
  ActivityList:any=[];
  ModalTitle:string;
  ActivateAddEditComp:boolean=false;
  act:any;
  url="https://localhost:44304/api/[controller]/[id]?id=";
  ngOnInit(): void {
  this.refreshActList();
  }

  addClick(){
    this.act={
      date:"",
      Id:0,
      streetId:0,
      Name:"",
      streetName:"",
      description:"",
    }
    this.ModalTitle="Add Activity";
    this.ActivateAddEditComp=true;
  }

  editClick(item){
    this.act = item;
    this.ModalTitle = "Edit Department"
    this.ActivateAddEditComp=true;
  }

  deleteClick(item){
    if(confirm('Are you sure??')){
      console.log("showactservice",item.id);
      this.http.delete(`${this.url}${item.id}`).subscribe(
        data=>{
          console.log(data);
          this.refreshActList();
        }
      )
      // this.service.deleteActivity(item.Id).subscribe(data=>{
      //   console.log(data);
      //   this.refreshActList();
      // })
    }
  }

  closeClick(){
    this.ActivateAddEditComp=false;
    this.refreshActList();
  }

  refreshActList(){
    this.service.getActList().subscribe(data=>{
      this.ActivityList=data;
    });
  }

}
