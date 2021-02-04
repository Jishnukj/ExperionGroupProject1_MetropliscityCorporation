import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-app-page2-activity-list',
  templateUrl: './app-page2-activity-list.component.html',
  styleUrls: ['./app-page2-activity-list.component.css']
})
export class AppPage2ActivityListComponent implements OnInit {

  headers=['Id','Activity Name', 'Street ID', 'Alternative Street', 'Activity Description', 'Date'];
  rows = [
    {
      "Id" : 1101,
      "Activity Name": "Road Maintenance in Sector 1",

      "Street ID" : 11,
      "Alternative Street" : "Mill Place",
      "Activity Description": ".......",
      "Date": "04-02-2021"
    },
    {
      "Id" : 1107,
      "Activity Name": "Pipe Maintenance in Noble Path",
      "Street ID" : 17,
      "Alternative Street" : "Farmer's Lane",
      "Activity Description": ".......",
      "Date": "04-02-2021"
    },
    {
      "Id" : 1105,
      "Activity Name": "Cleanliness Drive in Old Wharf",
      "Street ID" : 13,
      "Alternative Street" : "Oceanside Lane",
      "Activity Description": ".......",
      "Date": "04-02-2021"
    },{
      "Id" : 1103,
      "Activity Name": "Road Maintenance in Federation Avenue",
      "Street ID" : 14,
      "Alternative Street" : "Golf Links",
      "Activity Description": ".......",
      "Date": "04-02-2021"
    }

  ]

  constructor() { }

  ngOnInit(): void {
  }

}
