import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HouselistComponent } from './houselist/houselist.component';
import { HousecreateComponent } from './housecreate/housecreate.component';
import { HouseeditComponent } from './houseedit/houseedit.component';

const routes: Routes = [
  {path:'hlist',component:HouselistComponent},
  {path:'create',component:HousecreateComponent},
  {path:'edit/:id',component:HouseeditComponent},
  {path:'',redirectTo:'hlist',pathMatch:"full"}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
