import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './navigation/home/home.component';
import { DetailsComponent } from './eletronicPoint/details/details.component';

const routes: Routes = [
    { path: '',  component: HomeComponent, pathMatch: 'full' },
    { path: 'detail',  component: DetailsComponent },
  ];
  
  @NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
  })

export class AppRoutingModule {
    constructor() {}
}