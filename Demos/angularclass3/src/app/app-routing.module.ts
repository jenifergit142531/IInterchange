import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ContactComponent } from './contact/contact.component';
import { LoginComponent } from './login/login.component';
import { ErrorComponent } from './error/error.component';
import { PipeComponent } from './pipe/pipe.component';

const routes: Routes = [
  {
    path:'',redirectTo:'home',pathMatch:'full'
  },
  { 
    path:'pipe',component:PipeComponent
  },
  { 
    path:'home',component:HomeComponent
  },
  {
    path:'contact',component:ContactComponent,pathMatch:'prefix'
  },
  {
    path:'login',component:LoginComponent
  },
  {
    path:'**',component:ErrorComponent
  }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
