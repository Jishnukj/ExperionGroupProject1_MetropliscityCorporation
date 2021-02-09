import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
  url="https://localhost:44304/api/[controller]/[id]?id=";
  id=31;
readonly APIUrl = "https://localhost:44304/api/[controller]";
readonly APIUrl2 = "https://localhost:44304/api/[controller]/[id]";
  constructor(private http:HttpClient) { }

  getActList():Observable<any[]>{
    return this.http.get<any>(this.APIUrl);
  }

  addActivity(val:any){
    return this.http.post(this.APIUrl2,val)
  }

  updateActivity(val:any){
    return this.http.put(this.APIUrl2,val)
  }

  deleteActivity(val:any){
    console.log("hai",val);
    
    return this.http.delete(`${this.url}${this.id}`)
  }


}
