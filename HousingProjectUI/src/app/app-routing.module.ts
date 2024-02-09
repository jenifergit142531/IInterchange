import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HouselistComponent } from './houselist/houselist.component';
import { HousecreateComponent } from './housecreate/housecreate.component';
import { HouseeditComponent } from './houseedit/houseedit.component';
import { DetailsComponent } from './details/details.component';
import { LoginComponent } from './login/login.component';
import { TemplatedrivenComponent } from './templatedriven/templatedriven.component';
import { ReactiveComponent } from './reactive/reactive.component';

const routes: Routes = [
  {path:'hlist',component:HouselistComponent},
  {path:'create',component:HousecreateComponent},
  {path:'edit/:id',component:HouseeditComponent},
  {path:'details/:id',component:DetailsComponent},
  {path:'login',component:LoginComponent},
   {path:'reactive',component:ReactiveComponent},
  {path:'temp',component:TemplatedrivenComponent},

  {path:'',redirectTo:'hlist',pathMatch:"full"}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
