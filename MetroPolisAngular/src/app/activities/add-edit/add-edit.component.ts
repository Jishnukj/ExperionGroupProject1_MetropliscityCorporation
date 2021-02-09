import { Component, OnInit, Input } from '@angular/core';
import { SharedService } from 'src/app/shared.service';

@Component({
  selector: 'app-add-edit',
  templateUrl: './add-edit.component.html',
  styleUrls: ['./add-edit.component.css']
})
export class AddEditComponent implements OnInit {

  constructor(private service:SharedService) { }

  @Input() act:any;
  date:Date;
  Id:number;
  streetId:number;
  Name:string;
  streetName:string;
  description:string;

  ngOnInit(): void {
  this.date=this.act.date;
  this.Id=this.act.Id;
  this.streetId=this.act.streetId;
  this.Name=this.act.Name;
  this.streetName=this.act.streetName;
  this.description=this.act.description;
  }

  addActivity(){
    var val ={date:this.date,
              Id:this.Id,
              streetId:this.streetId,
              Name:this.Name,
              streetName:this.streetName,
              description:this.description
              };
    this.service.addActivity(val).subscribe(res =>{
      alert(res.toString());
    });

  }

  updateActivity(){
    var val ={date:this.date,
      Id:this.Id,
      streetId:this.streetId,
      Name:this.Name,
      streetName:this.streetName,
      description:this.description
      };
    this.service.updateActivity(val).subscribe(res =>{
      alert(res.toString());
    });

  }

}
