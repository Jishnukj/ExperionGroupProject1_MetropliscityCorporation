import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule,ReactiveFormsModule} from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import {HttpClientModule, HttpClient} from '@angular/common/http';

import { AppComponent } from './app.component';
import { AppPage1CitizenguidComponent } from './app-page1-citizenguid/app-page1-citizenguid.component';
import { AppPage1ImageComponent } from './app-page1-image/app-page1-image.component';
import { AppPage1FooterComponent } from './app-page1-footer/app-page1-footer.component';
import {ItemService} from './Services/item.service';
import { AppPage2LoginComponent } from './app-page2-login/app-page2-login.component';
import { AppPage2Component } from './app-page2/app-page2.component';
import { AppPage2ActivityListComponent } from './app-page2-activity-list/app-page2-activity-list.component';
import { AppPage3Component } from './app-page3/app-page3.component';
import { AppPage3AddactivityComponent } from './app-page3-addactivity/app-page3-addactivity.component';

import { ActivitiesComponent } from './activities/activities.component';
import { ShowActComponent } from './activities/show-act/show-act.component';
import { AddEditComponent } from './activities/add-edit/add-edit.component';
import { SharedService } from './shared.service';
import { AppPage3EditComponent } from './app-page3-edit/app-page3-edit.component';
import { AppPageNavComponent } from './app-page-nav/app-page-nav.component';
import { AppPage1Component } from './app-page1/app-page1.component';


@NgModule({
  declarations: [
    AppComponent,
    AppPage1CitizenguidComponent,
    AppPage1ImageComponent,
    AppPage1FooterComponent,
    AppPage2LoginComponent, 
    AppPage2Component,
    AppPage2ActivityListComponent,
    AppPage3Component,
    AppPage3AddactivityComponent,
    ActivitiesComponent,
    ShowActComponent,
    AddEditComponent,
    AppPage3EditComponent,
    AppPageNavComponent,
    AppPage1Component,
    
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [ItemService,SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }
