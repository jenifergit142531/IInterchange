import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HousecreateComponent } from './housecreate/housecreate.component';
import { HouselistComponent } from './houselist/houselist.component';
import { HouseeditComponent } from './houseedit/houseedit.component';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { TableModule } from 'primeng/table';
import { ButtonModule } from 'primeng/button';
import { ImageModule } from 'primeng/image';
import { NgForm } from '@angular/forms';
import { FormsModule } from '@angular/forms';
import { DetailsComponent } from './details/details.component';
import { LoginComponent } from './login/login.component';

@NgModule({
  declarations: [
    AppComponent,
    HousecreateComponent,
    HouselistComponent,
    HouseeditComponent,
    DetailsComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    TableModule,
    ButtonModule,
    ImageModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
