import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppPage1CitizenguidComponent } from './app-page1-citizenguid/app-page1-citizenguid.component';
import { AppPage1FooterComponent } from './app-page1-footer/app-page1-footer.component';
import { AppPage1Component } from './app-page1/app-page1.component';
import { AppPage2Component } from './app-page2/app-page2.component';
import { AppPage3AddactivityComponent } from './app-page3-addactivity/app-page3-addactivity.component';
import { AppPage3Component } from './app-page3/app-page3.component';

const routes: Routes = [
  {path:"", component:AppPage1Component},
  {path:"Guidelines", component:AppPage1CitizenguidComponent},
  {path:"AboutUs", component:AppPage1FooterComponent},
  {path:"ContactUs", component:AppPage1FooterComponent},
  {path:"Services", component:AppPage2Component, children:[
  {path:"Admin", component:AppPage3Component}
  ]},
  {path:"Home", component:AppPage1Component},
  {path:"**", component:AppPage3Component}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {
  
 }
