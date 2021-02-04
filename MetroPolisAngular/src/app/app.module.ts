import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AppPage1CitizenguidComponent } from './app-page1-citizenguid/app-page1-citizenguid.component';
import { AppPage1ImageComponent } from './app-page1-image/app-page1-image.component';
import { AppPage1FooterComponent } from './app-page1-footer/app-page1-footer.component';

@NgModule({
  declarations: [
    AppComponent,
    AppPage1CitizenguidComponent,
    AppPage1ImageComponent,
    AppPage1FooterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
