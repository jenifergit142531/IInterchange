import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PropertyCreateComponent } from './property-create/property-create.component';
import { PropertyListComponent } from './property-list/property-list.component';
import { PropertyEditComponent } from './property-edit/property-edit.component';
import { HomeComponent } from './home/home.component';
import { EnquireComponent } from './enquire/enquire.component';

const routes: Routes = [
  { path:'properties',component:PropertyListComponent },
  { path:'properties/create',component:PropertyCreateComponent },
  { path:'properties/edit/:id',component:PropertyEditComponent },
  { path:'home',component:HomeComponent },
  { path:'enquire',component:EnquireComponent },

  {path:'',redirectTo:'/home',pathMatch:'full'},
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
