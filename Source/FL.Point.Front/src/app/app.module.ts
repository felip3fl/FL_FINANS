import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HomeComponent } from './navigation/home/home.component';
import { AppRoutingModule } from './app-routing.module';
import { MenuComponent } from './navigation/menu/menu.component';
import { EletronicPointService } from './eletronicPoint/services/eletronic-point.service';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { DetailsComponent } from './eletronicPoint/details/details.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    MenuComponent,
    DetailsComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [
    EletronicPointService,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
